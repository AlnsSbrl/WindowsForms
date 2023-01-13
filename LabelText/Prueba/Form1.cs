using LabelText;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        int posicion = 0;
        int numColor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            posicion++;
            labelText1.Posicion = (ePosicion)(posicion % 2);
        }

        private void btnSeparar_Click(object sender, EventArgs e)
        {
            labelText1.Separacion += 20;
            //labelText1.Width += 20;
        }

        private void labelText1_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnCambiar.BackColor == Color.AliceBlue)
            {
                btnCambiar.BackColor = Color.Aquamarine;
            }
            else
            {
                btnCambiar.BackColor = Color.AliceBlue;
            }
        }

        private void labelText1_PosicionChanged(object sender, EventArgs e)
        {
            Text = labelText1.Posicion.ToString();
        }

        private void labelText1_SeparationChanged(object sender, EventArgs e)
        {
            MessageBox.Show("hola caracola");
        }

        private void labelText1_TxtChanged(object sender, EventArgs e)
        {
            numColor++;
            if (numColor % 2 == 0)
            {
                BackColor = Color.Pink;
            }
            else
            {
                BackColor = Color.MediumPurple;
            }
        }
    }
}
