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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KOTHARI-PC\SQLEXPRESS;Initial Catalog=ProjectDb;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from register where username='" + textBox1.Text + "' and password ='" +  textBox2.Text +"' ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                HomePage fm = new HomePage();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Username and Password are incorrect");
            }
        }
       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.AcceptsTab)
            {
                textBox2.UseSystemPasswordChar = false;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
          
        
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm rg = new RegisterForm();
            rg.Show();
        }
    }
}
