using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSimulator
{
    public partial class Form1 : Form
    {
        public string[] teclas;
        Color colorPorDefecto;     
        public Form1()
        {
            InitializeComponent();
            Icon = Properties.Resources.microsoft;
            Text = Properties.Resources.FormTitle;
            this.BackgroundImage = new Bitmap(Properties.Resources.curroMirateEstaPeli,this.Size);
            teclas = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };
            int widthPanel = panel1.Width;
            int heightPanel = panel1.Height;
            for (int i = 0; i < teclas.Length; i++)
            {
                Button b = new Button();
                b.Location = new Point(widthPanel * (i % 3) / 3, heightPanel / 4 * (i / 3));
                b.Text = teclas[i];
                b.Size = new Size(widthPanel / 3, heightPanel / 4);
                b.TabIndex = i;
                b.Tag = 0;
                b.Click += new System.EventHandler(ClickTecla);
                b.MouseEnter += new System.EventHandler(EnterTecla);
                b.MouseLeave += new System.EventHandler(SalirTecla);
                panel1.Controls.Add(b);
            }
            colorPorDefecto = panel1.Controls[0].BackColor;
        }

        public void ClickTecla(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.PapayaWhip;
            ((Button)sender).Tag = 1;
            textBox1.Text += ((Button)sender).Text;
        }
        public void EnterTecla(object sender, EventArgs e)
        {
            if ((int)((Button)sender).Tag != 1)
            {
                ((Button)sender).BackColor = Color.PaleVioletRed;
            }
        }

        public void SalirTecla(object sender, EventArgs e)
        {
            if ((int)((Button)sender).Tag != 1)
            {
                ((Button)sender).BackColor = colorPorDefecto;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (Button b in panel1.Controls)
            {
                b.Tag = 0;
                b.BackColor = colorPorDefecto;
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.AboutMessage, Properties.Resources.AboutTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                SaveFileDialog saveForm = new SaveFileDialog();
                saveForm.Title = Properties.Resources.SaveDialogTitle;
                saveForm.InitialDirectory = Environment.GetEnvironmentVariable("appdata");
                saveForm.Filter = Properties.Resources.SaveDialogFilter;
                DialogResult respuesta = saveForm.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(saveForm.FileName, true))
                        {
                            sw.WriteLine(textBox1.Text);
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("No se pudo guardar el número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Escriba un número primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2(teclas);
            DialogResult resu = f.ShowDialog();
            switch (resu)
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
