using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSimulator
{
    public partial class Form2 : Form
    {
        string pin="9999";
        int intentos = 3;
        public Form2(string[] teclas)
        {
            InitializeComponent();
            Icon = Properties.Resources.microsoft;
            Text = Properties.Resources.FormTitle;
            label1.Text = Properties.Resources.Form2SelectPassword;
            BackgroundImage = new Bitmap(Properties.Resources.hadesWallpaper, Size);
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
                panel1.Controls.Add(b);
            }
        }

        public void ClickTecla(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
            if (textBox1.Text.Length == 4)
            {
                if (textBox1.Text == pin)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    textBox1.Text = "";
                    intentos--;
                    if (intentos <= 0)
                    {
                        DialogResult = DialogResult.Cancel;
                    }                   
                }
            }
        }
    }
}
