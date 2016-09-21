namespace People
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.ComboPeople = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.txtEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.btnEmployeeCancel = new System.Windows.Forms.Button();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.txtSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSupplierLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSupplierFirstName = new System.Windows.Forms.TextBox();
            this.btnSupplierAdd = new System.Windows.Forms.Button();
            this.btnSupplierCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmployeeTitle = new System.Windows.Forms.TextBox();
            this.txtEmployeeWage = new System.Windows.Forms.TextBox();
            this.txtCustomerWage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel2);
            this.panel2.Controls.Add(this.btnSave2);
            this.panel2.Location = new System.Drawing.Point(188, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 212);
            this.panel2.TabIndex = 11;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(176, 186);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 2;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(95, 186);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 2;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.txtCustomerPhoneNumber);
            this.pnlCustomer.Controls.Add(this.label3);
            this.pnlCustomer.Controls.Add(this.lblCustomerLastName);
            this.pnlCustomer.Controls.Add(this.txtCustomerLastName);
            this.pnlCustomer.Controls.Add(this.lblCustomerFirstName);
            this.pnlCustomer.Controls.Add(this.txtCustomerFirstName);
            this.pnlCustomer.Controls.Add(this.btnCustomerAdd);
            this.pnlCustomer.Controls.Add(this.btnCustomerCancel);
            this.pnlCustomer.Location = new System.Drawing.Point(15, 33);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(427, 134);
            this.pnlCustomer.TabIndex = 8;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(268, 108);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerAdd.TabIndex = 1;
            this.btnCustomerAdd.Text = "Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.Location = new System.Drawing.Point(349, 108);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerCancel.TabIndex = 0;
            this.btnCustomerCancel.Text = "Cancel";
            this.btnCustomerCancel.UseVisualStyleBackColor = true;
            this.btnCustomerCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ComboPeople
            // 
            this.ComboPeople.FormattingEnabled = true;
            this.ComboPeople.Items.AddRange(new object[] {
            "Kund",
            "Anställd",
            "Leverantör"});
            this.ComboPeople.Location = new System.Drawing.Point(135, 6);
            this.ComboPeople.Name = "ComboPeople";
            this.ComboPeople.Size = new System.Drawing.Size(306, 21);
            this.ComboPeople.TabIndex = 7;
            this.ComboPeople.SelectedIndexChanged += new System.EventHandler(this.ComboPeople_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jag vill registrera en ny:";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(58, 6);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerFirstName.TabIndex = 2;
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(4, 9);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(48, 13);
            this.lblCustomerFirstName.TabIndex = 3;
            this.lblCustomerFirstName.Text = "Förnamn";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(58, 33);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerLastName.TabIndex = 4;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(3, 36);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(55, 13);
            this.lblCustomerLastName.TabIndex = 5;
            this.lblCustomerLastName.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TelefonNummer";
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(259, 5);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPhoneNumber.TabIndex = 7;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.txtCustomerWage);
            this.pnlEmployee.Controls.Add(this.txtEmployeeWage);
            this.pnlEmployee.Controls.Add(this.txtEmployeeTitle);
            this.pnlEmployee.Controls.Add(this.label11);
            this.pnlEmployee.Controls.Add(this.txtEmployeePhoneNumber);
            this.pnlEmployee.Controls.Add(this.label4);
            this.pnlEmployee.Controls.Add(this.label5);
            this.pnlEmployee.Controls.Add(this.txtEmployeeLastName);
            this.pnlEmployee.Controls.Add(this.label6);
            this.pnlEmployee.Controls.Add(this.txtEmployeeFirstName);
            this.pnlEmployee.Controls.Add(this.btnEmployeeAdd);
            this.pnlEmployee.Controls.Add(this.btnEmployeeCancel);
            this.pnlEmployee.Location = new System.Drawing.Point(448, 33);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(427, 134);
            this.pnlEmployee.TabIndex = 9;
            // 
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.Location = new System.Drawing.Point(259, 5);
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            this.txtEmployeePhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeePhoneNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TelefonNummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Efternamn";
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(58, 33);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeLastName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Förnamn";
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(58, 6);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeFirstName.TabIndex = 2;
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(268, 108);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeAdd.TabIndex = 1;
            this.btnEmployeeAdd.Text = "Add";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // btnEmployeeCancel
            // 
            this.btnEmployeeCancel.Location = new System.Drawing.Point(349, 108);
            this.btnEmployeeCancel.Name = "btnEmployeeCancel";
            this.btnEmployeeCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeCancel.TabIndex = 0;
            this.btnEmployeeCancel.Text = "Cancel";
            this.btnEmployeeCancel.UseVisualStyleBackColor = true;
            this.btnEmployeeCancel.Click += new System.EventHandler(this.btnEmployeeCancel_Click);
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.Controls.Add(this.txtCompanyName);
            this.pnlSupplier.Controls.Add(this.label12);
            this.pnlSupplier.Controls.Add(this.label10);
            this.pnlSupplier.Controls.Add(this.txtSupplierPhoneNumber);
            this.pnlSupplier.Controls.Add(this.label7);
            this.pnlSupplier.Controls.Add(this.label8);
            this.pnlSupplier.Controls.Add(this.txtSupplierLastName);
            this.pnlSupplier.Controls.Add(this.label9);
            this.pnlSupplier.Controls.Add(this.txtSupplierFirstName);
            this.pnlSupplier.Controls.Add(this.btnSupplierAdd);
            this.pnlSupplier.Controls.Add(this.btnSupplierCancel);
            this.pnlSupplier.Location = new System.Drawing.Point(881, 33);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(427, 134);
            this.pnlSupplier.TabIndex = 9;
            // 
            // txtSupplierPhoneNumber
            // 
            this.txtSupplierPhoneNumber.Location = new System.Drawing.Point(61, 71);
            this.txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber";
            this.txtSupplierPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierPhoneNumber.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "TelefonNr.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Efternamn";
            // 
            // txtSupplierLastName
            // 
            this.txtSupplierLastName.Location = new System.Drawing.Point(61, 45);
            this.txtSupplierLastName.Name = "txtSupplierLastName";
            this.txtSupplierLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierLastName.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Förnamn";
            // 
            // txtSupplierFirstName
            // 
            this.txtSupplierFirstName.Location = new System.Drawing.Point(61, 18);
            this.txtSupplierFirstName.Name = "txtSupplierFirstName";
            this.txtSupplierFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierFirstName.TabIndex = 2;
            // 
            // btnSupplierAdd
            // 
            this.btnSupplierAdd.Location = new System.Drawing.Point(268, 108);
            this.btnSupplierAdd.Name = "btnSupplierAdd";
            this.btnSupplierAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierAdd.TabIndex = 1;
            this.btnSupplierAdd.Text = "Add";
            this.btnSupplierAdd.UseVisualStyleBackColor = true;
            this.btnSupplierAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSupplierCancel
            // 
            this.btnSupplierCancel.Location = new System.Drawing.Point(349, 108);
            this.btnSupplierCancel.Name = "btnSupplierCancel";
            this.btnSupplierCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierCancel.TabIndex = 0;
            this.btnSupplierCancel.Text = "Cancel";
            this.btnSupplierCancel.UseVisualStyleBackColor = true;
            this.btnSupplierCancel.Click += new System.EventHandler(this.btnSupplierCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Kontaktperson";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Titel";
            // 
            // txtEmployeeTitle
            // 
            this.txtEmployeeTitle.Location = new System.Drawing.Point(58, 60);
            this.txtEmployeeTitle.Name = "txtEmployeeTitle";
            this.txtEmployeeTitle.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeTitle.TabIndex = 9;
            // 
            // txtEmployeeWage
            // 
            this.txtEmployeeWage.Location = new System.Drawing.Point(58, 86);
            this.txtEmployeeWage.Name = "txtEmployeeWage";
            this.txtEmployeeWage.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeWage.TabIndex = 10;
            // 
            // txtCustomerWage
            // 
            this.txtCustomerWage.AutoSize = true;
            this.txtCustomerWage.Location = new System.Drawing.Point(11, 89);
            this.txtCustomerWage.Name = "txtCustomerWage";
            this.txtCustomerWage.Size = new System.Drawing.Size(25, 13);
            this.txtCustomerWage.TabIndex = 11;
            this.txtCustomerWage.Text = "Lön";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Företag";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(226, 18);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 407);
            this.Controls.Add(this.pnlSupplier);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.ComboPeople);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.ComboBox ComboPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.TextBox txtEmployeePhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Button btnEmployeeCancel;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSupplierPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSupplierLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSupplierFirstName;
        private System.Windows.Forms.Button btnSupplierAdd;
        private System.Windows.Forms.Button btnSupplierCancel;
        private System.Windows.Forms.TextBox txtEmployeeTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtCustomerWage;
        private System.Windows.Forms.TextBox txtEmployeeWage;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label12;
    }
}

