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
    public partial class LogOutForm : Form
    {
        public LogOutForm()
        {
            InitializeComponent();
        }

        private void LogOutForm_Load(object sender, EventArgs e)
        {
            //LogOutForm
            label2.Text = login.name;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1
        }
        private void label2_Click(object sender, EventArgs e)
        {
            //panel2
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Create a list to store forms to close
            List<Form> formsToClose = new List<Form>();

            // Identify forms to close
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() != typeof(login))
                {
                    formsToClose.Add(form);
                }
            }

            // Close the identified forms
            foreach (Form form in formsToClose)
            {
                form.Close();
            }

            // Show the login form
            login loginForm = new login();
            loginForm.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            //rjButton2
            // Show the logout form again
            this.Close();



        }
    }
}
