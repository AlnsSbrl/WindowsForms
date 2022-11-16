using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriaImaxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Visor de imágenes";
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            //openFileDialog.ShowDialog();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "C:\\Users\\Pablo\\Desktop\\imagenes";
                ofd.Filter = "PNG files (*.png)|*.png |JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
                ofd.FilterIndex = 4;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    String filepath=ofd.FileName;
                    if (checkBoxModal.Checked)
                    {
                        FormImaxes f = new FormImaxes(filepath);                       
                        f.ShowDialog();
                    }
                    else
                    {
                        FormImaxes f = new FormImaxes(filepath);
                        f.Show();
                    }

                }
            }
        }

        
    }
}
