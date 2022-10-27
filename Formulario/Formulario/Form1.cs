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
            Icon = new Icon(@"C:\Users\Pablo\Desktop\Proyectos C#\WindowsForms\Formulario\Formulario\atari_icon.ico");
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
            if (MessageBox.Show("Quieres salir?", "Formulario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                botonColor.PerformClick();
            }
        }

        private void BotonImaxe_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBoxRutaImaxe.Text;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botonImaxe.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Boton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = (Color)((Button)sender).Tag;
        }

        private void Boton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = colorPorDefecto;
        }
    }
}