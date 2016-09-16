namespace RentaCar
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
            this.ShowCars = new System.Windows.Forms.Button();
            this.AddCar = new System.Windows.Forms.Button();
            this.ReturnCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlShowCars = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.listShowCar = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlShowCars.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowCars
            // 
            this.ShowCars.Location = new System.Drawing.Point(12, 32);
            this.ShowCars.Name = "ShowCars";
            this.ShowCars.Size = new System.Drawing.Size(76, 44);
            this.ShowCars.TabIndex = 0;
            this.ShowCars.Text = "Show Cars";
            this.ShowCars.UseVisualStyleBackColor = true;
            this.ShowCars.Click += new System.EventHandler(this.ShowCars_Click);
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(103, 32);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(76, 44);
            this.AddCar.TabIndex = 1;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseVisualStyleBackColor = true;
            // 
            // ReturnCar
            // 
            this.ReturnCar.Location = new System.Drawing.Point(193, 32);
            this.ReturnCar.Name = "ReturnCar";
            this.ReturnCar.Size = new System.Drawing.Size(76, 44);
            this.ReturnCar.TabIndex = 2;
            this.ReturnCar.Text = "Return Car";
            this.ReturnCar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // pnlShowCars
            // 
            this.pnlShowCars.Controls.Add(this.pnlInfo);
            this.pnlShowCars.Controls.Add(this.listShowCar);
            this.pnlShowCars.Location = new System.Drawing.Point(13, 82);
            this.pnlShowCars.Name = "pnlShowCars";
            this.pnlShowCars.Size = new System.Drawing.Size(259, 167);
            this.pnlShowCars.TabIndex = 5;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.lblColor);
            this.pnlInfo.Controls.Add(this.btnRent);
            this.pnlInfo.Controls.Add(this.lblModel);
            this.pnlInfo.Controls.Add(this.lblMake);
            this.pnlInfo.Location = new System.Drawing.Point(133, 4);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(123, 160);
            this.pnlInfo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Make:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(44, 38);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(35, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "label3";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(20, 134);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(44, 21);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(35, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "label2";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(44, 4);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(35, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "label2";
            // 
            // listShowCar
            // 
            this.listShowCar.FormattingEnabled = true;
            this.listShowCar.Location = new System.Drawing.Point(4, 4);
            this.listShowCar.Name = "listShowCar";
            this.listShowCar.Size = new System.Drawing.Size(122, 160);
            this.listShowCar.TabIndex = 0;
            this.listShowCar.SelectedIndexChanged += new System.EventHandler(this.listShowCar_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(335, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 167);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlShowCars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnCar);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.ShowCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlShowCars.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowCars;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button ReturnCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlShowCars;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.ListBox listShowCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label label5;
    }
}

