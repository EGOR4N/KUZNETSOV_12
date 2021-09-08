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
    public partial class HumburgerMenu : Form
    {
        
        
        

        public HumburgerMenu()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 MM = new Form1();
            MM.Show();
        }

        public void cheeseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseBox.Checked == true)
            {
                cheeseprice.Show();
                resultsum.Text = "";
            }
            else
            {
                cheeseprice.Hide();
            }    
        }

        public void saladBox_CheckedChanged(object sender, EventArgs e)
        {
            if (saladBox.Checked == true)
            {
                saladprice.Show();
                resultsum.Text = "";
            }
            else
            {
                saladprice.Hide();
            }
        }

        public void baconBox_CheckedChanged(object sender, EventArgs e)
        {
            if (baconBox.Checked == true)
            {
                baconprice.Show();
                resultsum.Text = "";
            }
            else
            {
                baconprice.Hide();
            }
        }

        public void cucumberBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cucumberBox.Checked == true)
            {
                cucumberprice.Show();
                resultsum.Text = "";
            }
            else
            {
                cucumberprice.Hide();
            }
        }

        public void tomatoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tomatoBox.Checked == true)
            {
                tomatoprice.Show();
                resultsum.Text = "";
            }
            else
            {
                tomatoprice.Hide();
            }
        }

        private void HumAddButton_Click(object sender, EventArgs e)
        {
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void resultlabel_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultbutton_Click(object sender, EventArgs e)
        {

            int Price = 15;
            int SumPrice = 70;
            double total;
            double humcount;
            humcount =(int)numerichum.Value;
            if (cucumberBox.Checked == true)
            {
                SumPrice += Price;
            }
            
            if (tomatoBox.Checked == true)
            {
                SumPrice += Price;
            }

            if (saladBox.Checked == true)
            {
                SumPrice += Price;
            }

            if (baconBox.Checked == true)
            {
                SumPrice += Price;
            }

            if (cheeseBox.Checked == true)
            {
                SumPrice += Price;
            }
            
            total = SumPrice;
            string st;
            if (humcount == 1)
            {
                st = "Цена Бургера: " + (SumPrice * humcount) + " руб.";
            }
            else
            {
                st = "Цена Бургеров: " + (SumPrice * humcount) + " руб.";
            }
            resultsum.Text = st;
        }

        private void numerichum_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OrderMenu om = new OrderMenu();
            om.Show();
            this.Hide();
        }
    }
}
