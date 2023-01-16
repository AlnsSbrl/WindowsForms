using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Prueba
{
    public partial class Form1 : Form
    {
        string path;
        string[] imageFilters = { ".jpg", ".jpeg", ".png", ".bmp", ".svg" };
        int imagenAMostrar = 0;
        int ticks = 0;
        int intervaloReal;
        Image[] imagenes;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i + "s");
            }
            comboBox1.SelectedIndex = 4;
            BackColor = Color.MediumPurple;
            pbImagenGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            timer = new Timer();
        }

        private void cambiaImagen(object sender, EventArgs e)
        {
            ticks += 1000;
            if (ticks % intervaloReal == 0)
            {
                imagenAMostrar++;
                if (imagenes != null)
                {
                    pbImagenGaleria.Image = imagenes[imagenAMostrar % imagenes.Length];
                }
            }
            reproductorMultimedia1.ActualizacionTiempoReproduccion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            DialogResult res = fb.ShowDialog();
            path = fb.SelectedPath;
            label1.Text = "Directorio seleccionado: " + path;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] files;
                if (dir.Exists)
                {
                    files = dir.GetFiles().Where(f => imageFilters.Contains(f.Extension.ToLower())).ToArray();
                    imagenes = new Image[files.Length];
                    for (int i = 0; i < files.Length; i++)
                    {
                        imagenes[i] = Image.FromFile(files[i].FullName);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("herror de acceso al arxivo illo");
            }
        }



        private void reproductorMultimedia1_PlayClick(object sender, EventArgs e)
        {
            if (!reproductorMultimedia1.hasPaused)
            {
                timer = new Timer();
                timer.Interval = 1000;
                intervaloReal = (comboBox1.SelectedIndex + 1) * 1000;
                timer.Tick += new EventHandler(cambiaImagen);
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void reproductorMultimedia1_DesbordaTiempo(object sender, EventArgs e)
        {
            reproductorMultimedia1.segundos = 0;
            reproductorMultimedia1.minutos++;
        }

        private void reproductorMultimedia1_NextClick(object sender, EventArgs e)
        {
            imagenAMostrar++;
            if (imagenes != null)
            {
                pbImagenGaleria.Image = imagenes[imagenAMostrar % imagenes.Length];
            }
        }

        private void reproductorMultimedia1_PrevClick(object sender, EventArgs e)
        {
            imagenAMostrar--;
            if (imagenAMostrar < 0)
            {
                imagenAMostrar = imagenes.Length;
            }
            
            if (imagenes != null)
            {
                pbImagenGaleria.Image = imagenes[imagenAMostrar % imagenes.Length];
            }
        }
    }
}
