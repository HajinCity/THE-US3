using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Cafe
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool TryAgain { get; private set; }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            login loginForm = Application.OpenForms.OfType<login>().FirstOrDefault();

            if (loginForm != null)
            {
                // If an instance of the login form exists, bring it to the front
                loginForm.BringToFront();
            }
            else
            {
                // If no instance exists, create a new one and show it
                loginForm = new login();
                loginForm.Show();
            }

            // Set TryAgain to true before closing
            TryAgain = true;

            // Close the current form (Form4)
            this.Close();
        }
    }



}

