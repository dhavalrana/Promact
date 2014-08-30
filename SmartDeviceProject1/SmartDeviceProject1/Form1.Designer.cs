namespace SmartDeviceProject1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.txtParkingBay = new System.Windows.Forms.TextBox();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblParkingBay = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(117, 83);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 20);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(117, 17);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(100, 21);
            this.txtVIN.TabIndex = 1;
            // 
            // txtParkingBay
            // 
            this.txtParkingBay.Location = new System.Drawing.Point(117, 45);
            this.txtParkingBay.Name = "txtParkingBay";
            this.txtParkingBay.Size = new System.Drawing.Size(100, 21);
            this.txtParkingBay.TabIndex = 2;
            // 
            // lblVIN
            // 
            this.lblVIN.Location = new System.Drawing.Point(15, 17);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(100, 20);
            this.lblVIN.Text = "VIN";
            // 
            // lblParkingBay
            // 
            this.lblParkingBay.Location = new System.Drawing.Point(15, 45);
            this.lblParkingBay.Name = "lblParkingBay";
            this.lblParkingBay.Size = new System.Drawing.Size(100, 20);
            this.lblParkingBay.Text = "ParkingBay";
            // 
            // lblSuccess
            // 
            this.lblSuccess.Location = new System.Drawing.Point(15, 115);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(202, 20);
            this.lblSuccess.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblParkingBay);
            this.Controls.Add(this.lblVIN);
            this.Controls.Add(this.txtParkingBay);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.btnSubmit);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Vehcile Parking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtParkingBay;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblParkingBay;
        private System.Windows.Forms.Label lblSuccess;

    }
}

