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

namespace ReproductorMultimedia
{
    public partial class ReproductorMultimedia: UserControl
    {
        int segundos = 0;
        int minutos = 0;
        
        public ReproductorMultimedia()
        {
            InitializeComponent();
            imgPlayPause.Image = new Bitmap(Properties.Resources.play_icon_png, new Size(20, 20));
            Height=imgPlayPause.Height;
            imgPlayPause.Location=new Point(0, 0);
            lblPlayTime.Location = new Point(imgPlayPause.Width,0);
            Width=imgPlayPause.Width+lblPlayTime.Width;
            lblPlayTime.Text = string.Format("{0:00}:{1:00}", minutos, segundos == 60 ? segundos : segundos % 60);
        }

        [Category("Acción")]
        [Description("Pausa o reproduce el contenido multimedia")]
        public event EventHandler PlayClick;
        public event EventHandler DesbordaTiempo;
        

        public void ActualizacionTiempoReproduccion()
        {
            segundos++;
            lblPlayTime.Text = string.Format("{0:00}:{1:00}", minutos, segundos==60?segundos:segundos%60);
            if(segundos<0 || minutos < 0)
            {
                throw new ArgumentException();
            }
            if (segundos == 60)
            {
                DesbordaTiempo?.Invoke(this,EventArgs.Empty);              
            }
        }
    }
}
