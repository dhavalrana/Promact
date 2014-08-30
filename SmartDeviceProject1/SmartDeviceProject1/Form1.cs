using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = InsertVehcileParkingHistory(Convert.ToString(txtVIN.Text), Convert.ToString(txtParkingBay.Text), "Dhaval");
                if (ret > 0)
                {
                    lblSuccess.Visible = true;
                    lblSuccess.Text = "Data save successfully";
                }
                else
                    lblSuccess.Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertVehcileParkingHistory(string VIN, string ParkingBay, string UserModified)
        {
            try
            {
                test.VehcileParkingHistory test = new SmartDeviceProject1.test.VehcileParkingHistory();
                return test.InsertVehcileParkingHistory(Convert.ToString(VIN), Convert.ToString(ParkingBay), UserModified);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}