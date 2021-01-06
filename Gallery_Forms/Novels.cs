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
    public partial class Novels : Form
    {
        public Novels()
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

        private void button5_Click(object sender, EventArgs e)
        {
            Login lp = new Login();
            lp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Item ani = new Add_New_Item();
            ani.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Novels";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        
    }
    }
}
