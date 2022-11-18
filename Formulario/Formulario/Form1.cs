using System.Windows.Forms.VisualStyles;

namespace Formulario
{
    public partial class Form1 : Form
    {
        static Color colorPorDefecto;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            Icon = Properties.Resources.atari;
            Cursor = Cursors.Hand;
            Text = "Formulario";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            colorPorDefecto = botonSair.BackColor;
            botonColor.Tag= Color.Beige;
            botonSair.Tag = Color.Aquamarine;
            botonImaxe.Tag = Color.Tan;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Queres saír?", "Formulario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Close();
        } 

        private void BotonCor_Click(object sender, EventArgs e)
        {            
            if(byte.TryParse(textBoxR.Text, out byte r)&& byte.TryParse(textBoxG.Text,out byte g)&& byte.TryParse(textBoxB.Text,out byte b)){
                Color color = Color.FromArgb(r, g, b);
                BackColor = color;
            }
            else
            {
                MessageBox.Show("Os parámetros R,G,B teñen que ser entre 0 e 255", "Erro", MessageBoxButtons.OK);
            }
        }

        private void buttonImaxe_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBoxRutaImaxe.Text;
        }     

        private void Boton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = (Color)((Button)sender).Tag;
        }

        private void Boton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = colorPorDefecto;
        }

        private void textBoxR_Enter(object sender, EventArgs e)
        {
            AcceptButton = botonColor;
        }

        private void textBoxRutaImaxe_Enter(object sender, EventArgs e)
        {
            AcceptButton = botonImaxe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}