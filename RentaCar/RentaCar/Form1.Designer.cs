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
            this.pnlShowCars = new System.Windows.Forms.Panel();
            this.CarsAvailable = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.listShowCar = new System.Windows.Forms.ListBox();
            this.pnlAddCar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMakeAdd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlReturnCar = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.listReturnCar = new System.Windows.Forms.ListBox();
            this.btnRents = new System.Windows.Forms.Button();
            this.pnlRents = new System.Windows.Forms.Panel();
            this.listRents = new System.Windows.Forms.ListBox();
            this.pnlShowCars.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
            this.pnlReturnCar.SuspendLayout();
            this.pnlRents.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowCars
            // 
            this.ShowCars.Location = new System.Drawing.Point(12, 22);
            this.ShowCars.Name = "ShowCars";
            this.ShowCars.Size = new System.Drawing.Size(50, 44);
            this.ShowCars.TabIndex = 0;
            this.ShowCars.Text = "Show Cars";
            this.ShowCars.UseVisualStyleBackColor = true;
            this.ShowCars.Click += new System.EventHandler(this.ShowCars_Click);
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(68, 22);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(50, 44);
            this.AddCar.TabIndex = 1;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // ReturnCar
            // 
            this.ReturnCar.Location = new System.Drawing.Point(124, 22);
            this.ReturnCar.Name = "ReturnCar";
            this.ReturnCar.Size = new System.Drawing.Size(50, 44);
            this.ReturnCar.TabIndex = 2;
            this.ReturnCar.Text = "Return Car";
            this.ReturnCar.UseVisualStyleBackColor = true;
            this.ReturnCar.Click += new System.EventHandler(this.ReturnCar_Click);
            // 
            // pnlShowCars
            // 
            this.pnlShowCars.Controls.Add(this.CarsAvailable);
            this.pnlShowCars.Controls.Add(this.pnlInfo);
            this.pnlShowCars.Controls.Add(this.listShowCar);
            this.pnlShowCars.Location = new System.Drawing.Point(13, 72);
            this.pnlShowCars.Name = "pnlShowCars";
            this.pnlShowCars.Size = new System.Drawing.Size(259, 181);
            this.pnlShowCars.TabIndex = 5;
            // 
            // CarsAvailable
            // 
            this.CarsAvailable.AutoSize = true;
            this.CarsAvailable.Location = new System.Drawing.Point(3, 168);
            this.CarsAvailable.Name = "CarsAvailable";
            this.CarsAvailable.Size = new System.Drawing.Size(131, 13);
            this.CarsAvailable.TabIndex = 5;
            this.CarsAvailable.Text = "We have 3 cars available!";
            this.CarsAvailable.Click += new System.EventHandler(this.CarsAvailable_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.txtCustomer);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer name";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(7, 92);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(113, 20);
            this.txtCustomer.TabIndex = 6;
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
            // pnlAddCar
            // 
            this.pnlAddCar.Controls.Add(this.btnAdd);
            this.pnlAddCar.Controls.Add(this.txtColor);
            this.pnlAddCar.Controls.Add(this.txtModel);
            this.pnlAddCar.Controls.Add(this.txtMake);
            this.pnlAddCar.Controls.Add(this.label8);
            this.pnlAddCar.Controls.Add(this.lblMakeAdd);
            this.pnlAddCar.Controls.Add(this.label6);
            this.pnlAddCar.Location = new System.Drawing.Point(314, 82);
            this.pnlAddCar.Name = "pnlAddCar";
            this.pnlAddCar.Size = new System.Drawing.Size(259, 167);
            this.pnlAddCar.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(248, 75);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(48, 60);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(208, 20);
            this.txtColor.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(48, 34);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(208, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(48, 8);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(208, 20);
            this.txtMake.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Color:";
            // 
            // lblMakeAdd
            // 
            this.lblMakeAdd.AutoSize = true;
            this.lblMakeAdd.Location = new System.Drawing.Point(7, 11);
            this.lblMakeAdd.Name = "lblMakeAdd";
            this.lblMakeAdd.Size = new System.Drawing.Size(37, 13);
            this.lblMakeAdd.TabIndex = 1;
            this.lblMakeAdd.Text = "Make:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Model:";
            // 
            // pnlReturnCar
            // 
            this.pnlReturnCar.Controls.Add(this.btnReturn);
            this.pnlReturnCar.Controls.Add(this.listReturnCar);
            this.pnlReturnCar.Location = new System.Drawing.Point(592, 80);
            this.pnlReturnCar.Name = "pnlReturnCar";
            this.pnlReturnCar.Size = new System.Drawing.Size(259, 167);
            this.pnlReturnCar.TabIndex = 6;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(88, 134);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return Car";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // listReturnCar
            // 
            this.listReturnCar.FormattingEnabled = true;
            this.listReturnCar.Location = new System.Drawing.Point(4, 7);
            this.listReturnCar.Name = "listReturnCar";
            this.listReturnCar.Size = new System.Drawing.Size(252, 121);
            this.listReturnCar.TabIndex = 0;
            this.listReturnCar.SelectedIndexChanged += new System.EventHandler(this.listReturnCar_SelectedIndexChanged);
            // 
            // btnRents
            // 
            this.btnRents.Location = new System.Drawing.Point(180, 22);
            this.btnRents.Name = "btnRents";
            this.btnRents.Size = new System.Drawing.Size(50, 44);
            this.btnRents.TabIndex = 7;
            this.btnRents.Text = "Rented Cars";
            this.btnRents.UseVisualStyleBackColor = true;
            this.btnRents.Click += new System.EventHandler(this.btnRents_Click_1);
            // 
            // pnlRents
            // 
            this.pnlRents.Controls.Add(this.listRents);
            this.pnlRents.Location = new System.Drawing.Point(870, 80);
            this.pnlRents.Name = "pnlRents";
            this.pnlRents.Size = new System.Drawing.Size(259, 167);
            this.pnlRents.TabIndex = 7;
            this.pnlRents.Paint += new System.Windows.Forms.PaintEventHandler(this.listRentedCars_Paint);
            // 
            // listRents
            // 
            this.listRents.FormattingEnabled = true;
            this.listRents.Location = new System.Drawing.Point(4, 4);
            this.listRents.Name = "listRents";
            this.listRents.Size = new System.Drawing.Size(252, 160);
            this.listRents.TabIndex = 0;
            this.listRents.SelectedIndexChanged += new System.EventHandler(this.listRents_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 261);
            this.Controls.Add(this.pnlRents);
            this.Controls.Add(this.btnRents);
            this.Controls.Add(this.pnlReturnCar);
            this.Controls.Add(this.pnlAddCar);
            this.Controls.Add(this.pnlShowCars);
            this.Controls.Add(this.ReturnCar);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.ShowCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlShowCars.ResumeLayout(false);
            this.pnlShowCars.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlAddCar.ResumeLayout(false);
            this.pnlAddCar.PerformLayout();
            this.pnlReturnCar.ResumeLayout(false);
            this.pnlRents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowCars;
        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button ReturnCar;
        private System.Windows.Forms.Panel pnlShowCars;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.ListBox listShowCar;
        private System.Windows.Forms.Panel pnlAddCar;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMakeAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Panel pnlReturnCar;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox listReturnCar;
        private System.Windows.Forms.Label CarsAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnRents;
        private System.Windows.Forms.Panel pnlRents;
        private System.Windows.Forms.ListBox listRents;
    }
}

