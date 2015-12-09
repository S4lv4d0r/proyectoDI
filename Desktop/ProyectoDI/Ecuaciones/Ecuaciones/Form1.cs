using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecuaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void primer_Click(object sender, EventArgs e)
        {
            FormPriemr lfPrimer = new FormPriemr();
            lfPrimer.Show();
        }
    }
}
