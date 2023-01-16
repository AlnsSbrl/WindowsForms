using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using ReproductorMultimedia.Properties;

namespace ReproductorMultimedia
{
    public partial class ReproductorMultimedia : UserControl
    {
        public int segundos = 0;
        public int minutos = 0;
        Bitmap imagenPlay;
        Bitmap imagenPause;
        Bitmap imagenNext;
        Bitmap imagenPrev;
        public bool hasPaused = false;
        public ReproductorMultimedia()
        {
            InitializeComponent();
            imagenPlay = new Bitmap(Properties.Resources.play, new Size(20, 20));
            imagenPause = new Bitmap(Properties.Resources.pause, new Size(20, 20));
            imagenNext = new Bitmap(Properties.Resources.nextButton, new Size(20, 20));
            imagenPrev = new Bitmap(Properties.Resources.beforeButton, new Size(20, 20));

            imgPrevious.Image = imagenPrev;
            imgPrevious.Location = new Point(0, 0);
            imgPlayPause.Image = imagenPlay;
            imgPlayPause.Location = new Point(imgPrevious.Width, 0);
            imgNext.Image = imagenNext;
            imgNext.Location = new Point(imgPrevious.Width+imgPlayPause.Width, 0);
            Height = imgPlayPause.Height;
            lblPlayTime.Location = new Point(imgPrevious.Width+imgPlayPause.Width+imgNext.Width, 0);
            Width = imgPrevious.Width+ imgPlayPause.Width+imgNext.Width + lblPlayTime.Width;
            lblPlayTime.Text = string.Format("{0:00}:{1:00}", minutos, segundos == 60 ? segundos : segundos % 60);
        }

        [Category("Acción")]
        [Description("Pausa o reproduce el contenido multimedia")]
        public event EventHandler PlayClick;
        public event EventHandler DesbordaTiempo;
        [Category("Acción")]
        [Description("Pasa al siguiente contenido multimedia")]
        public event EventHandler NextClick;
        [Category("Acción")]
        [Description("Pasa al anterior contenido multimedia")]
        public event EventHandler PrevClick;


        public void ActualizacionTiempoReproduccion()
        {
            lblPlayTime.Text = string.Format("{0:00}:{1:00}", minutos, segundos == 60 ? segundos : segundos % 60);
            segundos++;
            if (segundos < 0 || minutos < 0)
            {
                throw new ArgumentException();
            }
            if (segundos == 60)
            {
                DesbordaTiempo?.Invoke(this, EventArgs.Empty);
            }
        }

        private void imgPlayPause_Click(object sender, EventArgs e)
        {
            if (sender == imgPlayPause)
            {
                if (hasPaused)
                {
                    hasPaused = false;
                    imgPlayPause.Image = imagenPause;
                }
                else
                {
                    imgPlayPause.Image = imagenPlay;
                    hasPaused = true;
                }
                PlayClick?.Invoke(this, e);
            }
            if(sender == imgNext)
            {
                NextClick?.Invoke(this, e);
            }
            if (sender == imgPrevious)
            {
                PrevClick?.Invoke(this, e);
            }
        }
    }
}
