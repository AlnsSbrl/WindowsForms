using System.Collections;
using System.Windows.Forms.VisualStyles;

namespace Operaciones_Matematicas
{
    public delegate int Operaciones(int num1, int num2);
    public partial class Form1 : Form
    {
        Hashtable operacionesHash = new Hashtable();
        enum TagsNum1
        {
            Sumando = 1,
            Minuendo,
            Factor,
            Dividendo
        }
        enum TagsNum2
        {
            Sumando = 1,
            Sustraendo,
            Producto,
            Divisor
        }
        enum TagsResultado
        {
            Suma=1,
            Resto,
            Producto,
            Cociente     
        }
        int num1;
        int num2;
        Operaciones operacion;
        public Form1()
        {
            InitializeComponent();
            operacionesHash.Add("+", (Operaciones)((int num1, int num2) => { return num1 + num2; }));
            operacionesHash.Add("-", (Operaciones)((int num1, int num2) => { return num1 - num2; }));
            operacionesHash.Add("*", (Operaciones)((int num1, int num2) => { return num1 * num2; }));
            operacionesHash.Add("/", (Operaciones)((int num1, int num2) => { return num2 != 0 ? num1 / num2 : 0; }));
            textBoxErrores.BackColor = Color.Gray;
            textBoxErrores.ForeColor = Color.Red;
            Icon = Properties.Resources.math;
            operacion = (Operaciones)operacionesHash["+"];
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radioButton in groupBoxOperaciones.Controls)
            {
                if (radioButton.Checked)
                {
                    operacion = (Operaciones)operacionesHash[radioButton.Text];
                    labelSimboloOperacion.Text = radioButton.Text;
                    cambiaColor();
                    int num;
                    int.TryParse(radioButton.Tag.ToString(), out num);
                    cambiaNombresOperadores(num);
                }
            }
        }
        private void cambiaColor()
        {
            textBoxNum2.BackColor = (radioDivision.Checked && textBoxNum2.Text == "0") ? Color.Red : int.TryParse(textBoxNum2.Text, out num2) || textBoxNum2.Text == "" ? Color.White : Color.Red;
            textBoxErrores.Text = "";
            textBoxResultados.Text = "";
        }

        private void cambiaNombresOperadores(int operacion)
        {
            labelNombreNum1.Text = ((TagsNum1)operacion).ToString();
            labelNombreNum2.Text = ((TagsNum2)operacion).ToString();
            labelNombreResultado.Text = ((TagsResultado)operacion).ToString()+":";
        }
        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {
            textBoxNum1.BackColor = (int.TryParse(textBoxNum1.Text, out num1) || textBoxNum1.Text == "") ? Color.White : Color.Red;
            textBoxErrores.Text = "";
            textBoxResultados.Text = "";
        }

        private void textBoxNum2_TextChanged(object sender, EventArgs e)
        {
            cambiaColor();
        }

        private void botonOperacion_Click(object sender, EventArgs e)
        {
            if (textBoxNum1.Text == "" || textBoxNum2.Text == "")
            {
                textBoxErrores.Text = "Falta por rellenar alguno de los campos.\n";
            }
            if (textBoxNum1.BackColor == Color.Red || textBoxNum2.BackColor == Color.Red)
            {
                textBoxErrores.Text += "Alguno de los campos es erróneo";
            }
            if (textBoxNum1.Text != "" && textBoxNum1.BackColor == Color.White && textBoxNum2.Text != "" && textBoxNum2.BackColor == Color.White)
            {   
                int.TryParse(textBoxNum1.Text, out num1);
                int.TryParse(textBoxNum2.Text, out num2);
                textBoxResultados.Text = operacion.Invoke(num1, num2).ToString();
            }
        }
    }
}