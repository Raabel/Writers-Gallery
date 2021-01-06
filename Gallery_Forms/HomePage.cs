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
    public partial class HomePage : Form
    {
        private bool iscollapsed;
        public HomePage()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            panel1.AutoSize = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.TabStop)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books bk = new Books();
            bk.Show();

         



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Oops! Already on Dashboard.");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Login lp = new Login();
            lp.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Novels nv = new Novels();
            nv.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Research_papers rp = new Research_papers();
            rp.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewsPapers np = new NewsPapers();
            np.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Item ani = new Add_New_Item();
            ani.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books bk = new Books();
            bk.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image resources = null;
          
            if (iscollapsed)
            {
                DropDown.Height += 10;
                if (DropDown.Size == DropDown.MaximumSize)
                {
                    timer1.Stop();
                    iscollapsed = false;
                }
            }
            else
            {
                DropDown.Height -= 10;
                if (DropDown.Size == DropDown.MinimumSize)
                {
                    timer1.Stop();
                    iscollapsed = true;
                }

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Novels nv = new Novels();
            nv.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Research_papers rp = new Research_papers();
            rp.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewsPapers np = new NewsPapers();
            np.Show();
        }

        private void DropDown_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
