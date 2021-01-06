using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gallery_Forms
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login lp = new Login();
            lp.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
                MessageBox.Show("Please fill mandatory fields");
            else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("Password do not match");
            else
            {


                using (SqlConnection sqlcon = new SqlConnection(@"Data Source=KOTHARI-PC\SQLEXPRESS;Initial Catalog=ProjectDb;Integrated Security=True"))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Email", textBox2.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Password", textBox3.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@ConfirmPassword", textBox4.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful");
                    clear();
                }
            }
        }
        void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }
    }
}
