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
            FormPriemr lfPrimer = new FormPriemr(this);
            lfPrimer.Show();
            this.primer.Enabled = false;
            lfPrimer.EventoCierre += new FormPriemr.DelegadoCierre(cierre);
        }
        private void cierre()
        {
            if (!this.segundo.Enabled)
            {
                this.segundo.Enabled = true;
            }
            if (!this.primer.Enabled)
            {
                this.primer.Enabled = true;
            }
        }

        private void segundo_Click(object sender, EventArgs e)
        {
            FormSegun lfSeun = new FormSegun(this);
            lfSeun.Show();
            this.segundo.Enabled = false;
            lfSeun.EventoCierre += new FormSegun.DelegadoCierre(cierre);
        }
    }
}
