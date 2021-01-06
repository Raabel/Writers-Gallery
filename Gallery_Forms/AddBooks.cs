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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KOTHARI-PC\SQLEXPRESS;Initial Catalog=ProjectDb;Integrated Security=True");

        private void AddBooks_Load(object sender, EventArgs e)
        {
            
        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO BOOKS(Title, Author, category, PublicationYear ) VALUES ('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New Book Added Successfully !");
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login lp = new Login();
            lp.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Item ani = new Add_New_Item();
            ani.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
