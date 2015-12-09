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
    public partial class FormSegun : Form
    {
        public delegate void DelegadoCierre();
        public event DelegadoCierre EventoCierre;
        private int a { get; set; }
        private int b { get; set; }
        private int c{get;set;}
        private int d{get;set;}
        public FormSegun(Form1 padre)
        {
            InitializeComponent();
            this.Owner = padre;
        }
        private void updateFormula()
        {
            this.label6.Text = a + " x^2 + (" + b + ") x + (" + c + ") = " + d;
        }

        private void textoNumerico1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = (int)Convert.ToInt32(this.textoNumerico1.Text);
                updateFormula();
            }
            catch (Exception ex) { }
        }

        private void textoNumerico2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = (int)Convert.ToInt32(this.textoNumerico2.Text);
                updateFormula();
            }
            catch (Exception ex) { }
        }

        private void textoNumerico3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c = (int)Convert.ToInt32(this.textoNumerico3.Text);
                updateFormula();
            }
            catch (Exception ex) { }
        }

        private void textoNumerico4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                d = (int)Convert.ToInt32(this.textoNumerico4.Text);
                updateFormula();
            }
            catch (Exception ex) { }
        }

        private void FormSegun_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.EventoCierre();
        }

        private void FormSegun_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Owner.Location.X, this.Owner.Location.Y + this.Owner.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double x1, x2;
            ResolverEcuacionesSegundo.resolve(a, b, c, d, out x1, out x2);
            MessageBox.Show("Solucion x1= " + x1 + "\nSolucion x2= " + x2);
            this.EventoCierre();
            reset();
        }
        private void reset()
        {
            this.textoNumerico1.Text = "";
            this.textoNumerico2.Text="";
            this.textoNumerico3.Text="";
            this.textoNumerico4.Text = "";
            this.textoNumerico1.Focus();
        }
    }
}
