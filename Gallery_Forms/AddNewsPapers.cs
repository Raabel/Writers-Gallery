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
    public partial class AddNewsPapers : Form
    {
        public AddNewsPapers()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {

        }
        

    }
}
