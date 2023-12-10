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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //HomeForm
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //rjButton1
            AddingMenu addingMenu = new AddingMenu();
            addingMenu.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            //rjButton2
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            //rjButton3
        }
    }
}
