using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelText
{
    public enum eMarca
    {
        Nada, Cruz, Circulo
    }
    public partial class EtiquetaAviso : Control
    {
        private eMarca marca = eMarca.Nada;
        [Category("appearance")]
        [Description("Indica el tipo de marca al lado del texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                Refresh();
            }
            get
            {
                return marca;
            }
        }

        private bool gradiente = false;
        [Category("appearance")]
        [Description("Indica si se realiza un gradiente o no entre dos colores")]
        public bool Gradiente
        {
            set { gradiente = value; }
            get { return gradiente; }//se pueden ocultar los atributos 
            //es decir, se puede hacer que solo se muestre la propiedad "colores gradiente"
            //cuando este Gradiente esté en positivo?
        }
        [Category("appearance")]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            int grosor = 0;
            int offsetX = 0;
            int offsetY = 0;
            int h = Font.Height;
            g.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.PeachPuff, grosor), grosor, grosor, h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;

                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Plum, grosor);
                    g.DrawLine(lapiz,grosor,grosor,h,h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX=h + grosor;
                    offsetY = grosor / 2; //vale, esto es para poder hacer fuera el offset*2
                    lapiz.Dispose();
                    break;
            }

            SolidBrush brush = new SolidBrush(ForeColor);
            g.DrawString(Text, Font, brush, offsetX+grosor, offsetY);
            Size tamaño = g.MeasureString(Text, Font).ToSize();
            Size=new Size(tamaño.Width+offsetX+grosor,tamaño.Height+offsetY*2);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Refresh();
        }
    }
}
