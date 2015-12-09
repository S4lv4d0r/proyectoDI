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
    public partial class FormPriemr : Form
    {
        private int a{get;set;}
        private int b{get;set;}
        private int c{get;set;}
        public FormPriemr()
        {
            InitializeComponent();            
        }
        private void updateFormula()
        {
            if(b>=0)
            {
                this.label5.Text = a + "x + " + b + " = " + c;
            }
            else
            {
                this.label5.Text = a + "x " + b + " = " + c;
            }
            
        }

        private void textoNumerico1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = (int)Convert.ToInt32(this.textoNumerico1.Text);
            }
            catch (Exception ex) { }
            this.updateFormula();
        }

        private void textoNumerico2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = (int)Convert.ToInt32(this.textoNumerico2.Text); 
            }
            catch (Exception ex) { }
            this.updateFormula();
        }

        private void textoNumerico3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c = (int)Convert.ToInt32(this.textoNumerico3.Text);
            }
            catch(Exception ex){}
            this.updateFormula();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double x;
            ResolverEcuacionesPrimer.resolve(a, b, c, out x);
            MessageBox.Show("Solución: " + x);
            reset();

        }
        private void reset()
        {
            this.textoNumerico1.Text = "";
            this.textoNumerico2.Text = "";
            this.textoNumerico3.Text = "";
            this.textoNumerico1.Focus();
        }
    }
}
