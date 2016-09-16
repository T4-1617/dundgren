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
            this.btnRent = new System.Windows.Forms.Button();
            this.listShowCar = new System.Windows.Forms.ListBox();
            this.pnlShowCars.SuspendLayout();
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
            this.pnlShowCars.Controls.Add(this.btnRent);
            this.pnlShowCars.Controls.Add(this.listShowCar);
            this.pnlShowCars.Location = new System.Drawing.Point(13, 82);
            this.pnlShowCars.Name = "pnlShowCars";
            this.pnlShowCars.Size = new System.Drawing.Size(259, 167);
            this.pnlShowCars.TabIndex = 5;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(90, 132);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // listShowCar
            // 
            this.listShowCar.FormattingEnabled = true;
            this.listShowCar.Location = new System.Drawing.Point(4, 4);
            this.listShowCar.Name = "listShowCar";
            this.listShowCar.Size = new System.Drawing.Size(252, 121);
            this.listShowCar.TabIndex = 0;
            this.listShowCar.SelectedIndexChanged += new System.EventHandler(this.listShowCar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlShowCars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnCar);
            this.Controls.Add(this.AddCar);
            this.Controls.Add(this.ShowCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlShowCars.ResumeLayout(false);
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
    }
}

