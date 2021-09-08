using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HumburgerMenu HM = new HumburgerMenu();
            HM.Show();
        }

       




        private void Exitbutton_Click_1(object sender, EventArgs e)
        {
            Exitwin ew = new Exitwin();
            ew.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OrderMenu om = new OrderMenu();
            om.Show();
            this.Hide();
        }
    }
}
