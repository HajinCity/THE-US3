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
    public partial class MenuSuccessfully : Form
    {
        private AddingMenu addingMenu;

        public MenuSuccessfully(AddingMenu addingMenu)
        {
            InitializeComponent();
            this.addingMenu = addingMenu;
        }


        private void MenuSuccessfully_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.addingMenu.Close(); // Close the AddingMenu form
            this.Close(); // Close the MenuSuccessfully form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
