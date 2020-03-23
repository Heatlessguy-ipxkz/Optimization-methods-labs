using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _MO_Lab1
{
    public partial class Form1 : Form
    {
        private int intervals = 10000;
        private double step = 0.001;
        private double XL = 0;
        private double XR = 5;
        private double Dih = 0, Gold = 0, Sea = 0, Mid = 0, Newt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private double funct(double X, int proizv = 0)
        {
            //if (proizv == 1)
            //{
            //    return (X * X * X) + (2 * X) - 8;
            //}
            //    return (X * X * X * X) / 4 + (X * X) - 8 * X + 12;

            //4x*x*x-36x2+94x-60 
            if (proizv == 1)
            {
                return 4 * (X * X * X) - 36 * (X * X) + 94 * X - 60;
            }
            if (proizv == 2)
            {
                return 12 * (X * X) - 72 * X + 94;
                //return Math.Pow(94, X) * Math.Log(94) + 12 * Math.Pow(X, 2) - 72 * X;
            }
            return X * X * X * X - 12 * (X * X * X) + 47 * (X * X) - 60 * X;
        }



        private void bOk_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            lDih.Text = "Метод дихотомии = " + (Dih = Dichotomy(XL, XR, step));
            lGold.Text = "Метод золотого сечения = " + (Gold = GoldenSection(XL, XR, step));
            lSearch.Text = "Метод равномерного поиска = " + (Sea = Search(XL, XR, intervals));
            INewton.Text = "Метод Ньютона = " + (Newt = Newton(XL, step));
            IMiddlePoint.Text = "Метод средней точки = " + (Mid = middle_point(XL, XR, step));
        }



        private double Search(double a, double b, int iterations)
        {
            List<double> XArray = new List<double>();
            List<double> YArray = new List<double>();
            for (int i = 1; i < iterations; i++)
            {
                double temp = (a + (i * ((b - a) / (iterations + 1))));
                XArray.Add(temp);
                YArray.Add(funct(temp));
            }

            double answer = 10000;
            int id = 0;

            for(int i = 0; i < YArray.Count; i++)
            {
                if (YArray[i] < answer)
                {
                    answer = YArray[i];
                    id = i;
                }
            }
            return XArray[id];
        }

        private double Dichotomy(double a, double b, double pogr)
        {
            double y, z;
            double eps = pogr * 0.2;
            do
            {
                y = (a + b - eps) / 2;
                z = (a + b + eps) / 2;
                if (funct(y) <= funct(z))
                    b = z;
                else
                    a = y;
            }
            while (Math.Abs(b - a) > pogr); 
            return (a + b) / 2;
        }

        private double GoldenSection(double a, double b, double pogr)
        {
            double y = a + ((3 - Math.Sqrt(5)) / 2) * (b - a);
            double z = a + b - y;

            do
            {
                if (funct(y) <= funct(z))
                {
                    b = z;
                    z = y;
                    y = a + b - y;
                }
                else
                {
                    a = y;
                    y = z;
                    z = a + b - z;
                }
            }
            while (Math.Abs(b - a) > pogr);
            return (a + b) / 2;
        }

        private double Newton(double a, double pogr)
        {
            int iterations = 0;
            double f1x;
            do
            {
                f1x = funct(a, 1);
                a -= f1x / funct(a, 2);
                iterations++;
            }  while (Math.Abs(f1x = funct(a, 1)) > pogr);
            //Console.WriteLine("Newton iterations: {0}", iterations);
            return a;
        }

        private double middle_point(double a, double b, double pogr)
        {
            int iterations = 0;
            double z, f1z;
            do
            {
                iterations++;
                z = (a + b) / 2;
                f1z = funct(z, 1);
                if (f1z < 0)
                    a = z;
                else
                    b = z;
            } while (Math.Abs(f1z) > pogr);
            //Console.WriteLine("Middle point iterations: {0}", iterations);
            return z;
        }
        }
}
