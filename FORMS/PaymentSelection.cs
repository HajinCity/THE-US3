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
    public partial class PaymentSelection : Form
    {
        public PaymentSelection()
        {
            InitializeComponent();
            this.FormClosed += GcashPayment_FormClosed;
            this.FormClosed += CashPayment_FormClosed;
        }

        
        private void GcashPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the PaymentSelection form when GcashPayment form is closed
            if (Owner is PaymentSelection paymentSelectionForm)
            {
                paymentSelectionForm.Show();
            }
        }

        private void CashPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the PaymentSelection form when CashPayment form is closed
            if (Owner is PaymentSelection paymentSelectionForm)
            {
                paymentSelectionForm.Show();
            }
        }






        private void PaymentSelection_Load(object sender, EventArgs e)
        {
            //PaymentSelection
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1
        }
        private void label2_Click(object sender, EventArgs e)
        {
            //label2
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseForms();
        }

        private void CloseForms()
        {
            // Assuming that the PayNow form is the owner of the PaymentSelection form
            if (Owner is PayNow payNowForm)
            {
                payNowForm.Close();  // Close the PayNow form
                Close();  // Close the PaymentSelection form
            }
        }





        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Open GcashPayment form
            GcashPayment gcashPaymentForm = new GcashPayment();

            // Assuming that the PaymentSelection form is the owner of the GcashPayment form
            gcashPaymentForm.Owner = this;

            // Show the GcashPayment form
            gcashPaymentForm.Show();

            // Optionally, hide the PaymentSelection form
           
        }


        private void rjButton2_Click(object sender, EventArgs e)
        {
            //rjButton2
            //Cash Selection
            CashPayment cashPaymentForm = new CashPayment();

            // Assuming that the PaymentSelection form is the owner of the CashPayment form
            cashPaymentForm.Owner = this;

            // Show the CashPayment form
            cashPaymentForm.Show();

            // Optionally, hide the PaymentSelection form
            
        }
    }
}
