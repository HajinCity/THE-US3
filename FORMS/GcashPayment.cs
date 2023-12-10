using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Cafe.FORMS
{
    public partial class GcashPayment : Form
    {
        public GcashPayment()
        {
            InitializeComponent();

        }




        private void GcashPayment_Load(object sender, EventArgs e)
        {
            //GcashPayment Form
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1
            //Gcash text
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label2
            //Scan Text
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3
            //ME text
        }
        private void label4_Click(object sender, EventArgs e)
        {
            //label4
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //pictureBox2
            //Gcash QR code picture
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //rjButton1
            //Done button
            SuccessfulPayment successfulPayment = new SuccessfulPayment();
            successfulPayment.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}