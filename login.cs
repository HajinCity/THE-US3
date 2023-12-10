using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CustomControls.RJControls;
using System.Data.SqlClient;
using System.Linq.Expressions;


namespace _3Cafe
{
    public partial class login : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public login()
        {
            InitializeComponent();
        }
        public static string name, position;

        private int loginAttempts = 0;
        private const int maxAttempts = 4;

        private void LOGIN()
        {
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT id, name, position, usn, pswd FROM user WHERE usn = @usn AND pswd = @pswd";
                cmd.Parameters.AddWithValue("@usn", usn.Text);
                cmd.Parameters.AddWithValue("@pswd", pswd.Text);

                cmd.CommandTimeout = 3600;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    label3.Text = dr["name"].ToString();
                    label4.Text = dr["position"].ToString();

                    name = label3.Text;
                    position = label4.Text;

                    Form2 dash = new Form2();
                    this.Hide();
                    dash.Show();
                    dash.Focus();
                }
                else
                {
                    loginAttempts++;

                    if (loginAttempts >= maxAttempts)
                    {
                        MessageBox.Show("Maximum login attempts reached. Closing application.");
                        Application.Exit();
                    }
                    else
                    {
                        Form4 error = new Form4();
                        error.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage;

                if (ex is FormatException || ex is OverflowException)
                {
                    errorMessage = "Invalid input format. Please check the entered values.";
                }
                else if (ex is SqlException sqlEx)
                {
                    errorMessage = "Database error. Please check your data and try again. Error code: " + sqlEx.Number;
                }
                else
                {
                    errorMessage = "An unexpected error occurred. Please contact support for assistance.";
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

       

        private void pswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswd_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();


            }
        }

        private void pswd_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            LOGIN();


        }
    }
}

    
