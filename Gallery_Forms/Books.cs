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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KOTHARI-PC\SQLEXPRESS;Initial Catalog=ProjectDb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        public void SearchData(string ValueToSearch)
        {
            string query = "SELECT * FROM Books WHERE CONCAT(Title, Author, category, PublicationYear) like '%"  +ValueToSearch + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new DataTable();
            sda.Fill(da);

            sda.SelectCommand.ExecuteNonQuery();
            dataGridView1.DataSource = da;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login lp = new Login();
            lp.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Item ani = new Add_New_Item();
            ani.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM BOOKS";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddBooks ab = new AddBooks();
            ab.Show();
           
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            string query = "SELECT * FROM Books  where Title like '" + textBox1.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable da = new DataTable();
            sda.Fill(da);

            
            dataGridView1.DataSource = da;
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
