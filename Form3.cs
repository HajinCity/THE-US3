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
    public partial class Form3 : Form
    {
        private Form activeForm;
        public Form3()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            //Form3
            label1.Text = login.name;
            label2.Text = login.position;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1
        }
        private void label2_Click(object sender, EventArgs e)
        {
            //label2
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void rjButton1_Click(object sender, EventArgs e)
        {
            //rjButton1
            OpenChildForm(new FORMS.HomeForm());

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            //rjButton2
            OpenChildForm(new FORMS.MenuForm());
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            //rjButton3
            OpenChildForm(new FORMS.SalesTracking());

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            //rjButton4
            OpenChildForm(new FORMS.LogOutForm());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //panel5
        }

       
    }
}
