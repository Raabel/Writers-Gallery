using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery_Forms
{
    public partial class Add_New_Item : Form
    {
        public Add_New_Item()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops! Already on Add New Item page.");
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

        private void Add_New_Item_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBooks ab = new AddBooks();
            ab.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNovels an = new AddNovels();
            an.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddResearchPapers arp = new AddResearchPapers();
            arp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewsPapers anp = new AddNewsPapers();
            anp.Show();
        }
    }
}
