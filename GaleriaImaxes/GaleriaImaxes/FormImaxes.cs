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

namespace GaleriaImaxes
{
    public partial class FormImaxes : Form
    {
        public FormImaxes(String filepath)
        {
            InitializeComponent();
            Size = Image.FromFile(filepath).Size;
            Icon = Properties.Resources.jojo;
            pictureBox1.Image= Image.FromFile(filepath);
            FileInfo file = new FileInfo(filepath);
            Text = file.Name;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bounds = pictureBox1.Bounds;
        }
                        
        private void FormImaxes_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = Size;
        }
    }
}
