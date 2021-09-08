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
    public partial class Exitwin : Form
    {
        public Exitwin()
        {
            InitializeComponent();
        }

        private void confex_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancex_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
