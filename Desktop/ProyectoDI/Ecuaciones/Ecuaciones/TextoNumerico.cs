using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecuaciones
{
    public partial class TextoNumerico : TextBox
    {
        public TextoNumerico()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '-') ||//controla los parametros que puedo introducir
                (e.KeyChar == '-' && SelectionStart > 0) ||//solo puedo poner el menos delante de todos
                (SelectionStart == 0 && Text.IndexOf('-') > -1))//solo puedo poner un menos
            {
                //Si no es un numero o una tecla de control, dalo por hecho
                e.Handled = true;
            }
            else
            {
                base.OnKeyPress(e);
            }
            //no lo quitamos porque hace muchas mas cosas
            //a partir de ahora empezamos a capar
        }
    }
}
