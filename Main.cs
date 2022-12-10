using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatOsoba
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void zavisniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nezavisniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmOsoba osoba = new fmOsoba();
            osoba.Show();
        }

        private void odeljenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmOdeljenje odeljenje = new fmOdeljenje();
            odeljenje.Show();
        }
    }
}
