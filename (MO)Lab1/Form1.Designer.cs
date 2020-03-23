namespace _MO_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bClose = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.lDih = new System.Windows.Forms.Label();
            this.lGold = new System.Windows.Forms.Label();
            this.lSearch = new System.Windows.Forms.Label();
            this.INewton = new System.Windows.Forms.Label();
            this.IMiddlePoint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(347, 130);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "Выход";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bOk
            // 
            this.bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bOk.Location = new System.Drawing.Point(347, 12);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 112);
            this.bOk.TabIndex = 2;
            this.bOk.Text = "Расчитать";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // lDih
            // 
            this.lDih.AutoSize = true;
            this.lDih.Location = new System.Drawing.Point(12, 9);
            this.lDih.Name = "lDih";
            this.lDih.Size = new System.Drawing.Size(108, 13);
            this.lDih.TabIndex = 3;
            this.lDih.Text = "Метод дихотомии = ";
            // 
            // lGold
            // 
            this.lGold.AutoSize = true;
            this.lGold.Location = new System.Drawing.Point(12, 53);
            this.lGold.Name = "lGold";
            this.lGold.Size = new System.Drawing.Size(141, 13);
            this.lGold.TabIndex = 4;
            this.lGold.Text = "Метод золотого сечения =";
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Location = new System.Drawing.Point(12, 31);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(163, 13);
            this.lSearch.TabIndex = 5;
            this.lSearch.Text = "Метод равномерного поиска =";
            // 
            // INewton
            // 
            this.INewton.AutoSize = true;
            this.INewton.Location = new System.Drawing.Point(12, 77);
            this.INewton.Name = "INewton";
            this.INewton.Size = new System.Drawing.Size(96, 13);
            this.INewton.TabIndex = 6;
            this.INewton.Text = "Метод Ньютона =";
            // 
            // IMiddlePoint
            // 
            this.IMiddlePoint.AutoSize = true;
            this.IMiddlePoint.Location = new System.Drawing.Point(12, 102);
            this.IMiddlePoint.Name = "IMiddlePoint";
            this.IMiddlePoint.Size = new System.Drawing.Size(124, 13);
            this.IMiddlePoint.TabIndex = 7;
            this.IMiddlePoint.Text = "Метод средней точки =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 175);
            this.Controls.Add(this.IMiddlePoint);
            this.Controls.Add(this.INewton);
            this.Controls.Add(this.lSearch);
            this.Controls.Add(this.lGold);
            this.Controls.Add(this.lDih);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bClose);
            this.Name = "Form1";
            this.Text = "Lab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label lDih;
        private System.Windows.Forms.Label lGold;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.Label INewton;
        private System.Windows.Forms.Label IMiddlePoint;
    }
}

