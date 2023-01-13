using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LabelText
{
    //Indica donde está la etiqueta respecto al TextBox
    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }
    public partial class LabelText : UserControl
    {
        public LabelText()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }

        [Category("Property Changed")]
        [Description("Se lanza cuando la propiedad separación es modificada")]
        public event EventHandler SeparationChanged;

        [Category("Property Changed")]
        [Description("Se lanza cuando se cambia el texto")]
        public event EventHandler TxtChanged;

        [Category("Property Changed")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler PosicionChanged;

        [Category("Property")]
        [Description("Caracter para ocultar el texto")]
        public char PswChar
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        private ePosicion posicion = ePosicion.IZQUIERDA;
        [Category("Property")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    OnPosicionChanged(EventArgs.Empty);
                    recolocar();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Property")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    OnSeparationChange(EventArgs.Empty);
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }
        [Category("Property")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Property")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }
        public virtual void OnSeparationChange(EventArgs e)
        {
            SeparationChanged?.Invoke(this, e);
        }

        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            OnTxtChanged(e);
        }
        protected virtual void OnTxtChanged(EventArgs e)
        {
            TxtChanged?.Invoke(this, e);
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);                   
                    txt.Location = new Point(lbl.Width + Separacion, 0);                                   
                    break;
                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    break;
            }
            Height = Math.Max(txt.Height, lbl.Height);
            Width = txt.Width + lbl.Width + Separacion;
        }
    }
}
