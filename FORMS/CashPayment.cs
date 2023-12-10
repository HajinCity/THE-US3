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
    public partial class CashPayment : Form
    {
        public CashPayment()
        {
            InitializeComponent();
            
        }

        
        private void CashPayment_Load(object sender, EventArgs e)
        {
            //CashPayment Form
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1
            //Amount Text
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label2
            //Total Text
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3
            //Change Text
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //label4
            //O text for total
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //label5
            //0 text for change
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //rjButton1
            //Confirm Button for Payment
            SuccessfulPayment successfulPayment = new SuccessfulPayment();
            successfulPayment.Show();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            //rjTextBox1
            //Input amount of payment
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
