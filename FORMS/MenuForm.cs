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
    public partial class MenuForm : Form
    {

        private Form activeForm;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            //MenuForm
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel3
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //panel4
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //panel5

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            //panel6
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            //panel7
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            //panel8
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            //panel9
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            //panel10
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //label2
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //label4
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //label5
        }

        private void OpenChildForm(Form childForm)
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

            OpenChildForm(new MenuFunctions.AllMenus());
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            //rjButton2
            OpenChildForm(new MenuFunctions.Category1());
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            //rjButton3
            OpenChildForm(new MenuFunctions.Category2());
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            //rjButton4
            OpenChildForm(new MenuFunctions.Category3());
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            //rjButton5
            PayNow payNowForm = new PayNow();
            payNowForm.Owner = this;  // Set the owner to MenuForm
            payNowForm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //subtotal value
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //discount value
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //Vat value
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //Total Value
        }
    }
}
