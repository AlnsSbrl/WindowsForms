//#define caracter
namespace MouseTester
{
    public partial class Form1 : Form
    {

        static Color colorPorDefecto;
        public Form1()
        {
            InitializeComponent();
            colorPorDefecto = button1.BackColor;
            button1.Tag = Color.PapayaWhip;
            button2.Tag = Color.PeachPuff;
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (sender.GetType() == typeof(Button))
            {
                //"{X=,Y=}";
                int X = e.Location.X + ((Button)sender).Location.X;
                int Y = e.Location.Y + ((Button)sender).Location.Y;

                Text = "{X=" + X.ToString() + ",Y=" + Y.ToString() + "}";
            }
            else
            {
                Text = e.Location.ToString();
            }

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = Tag.ToString();
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = colorPorDefecto;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = colorPorDefecto;
            }
            else
            {
                button2.BackColor = colorPorDefecto;
                button1.BackColor = colorPorDefecto;

            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = (Color)button1.Tag;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = (Color)button2.Tag;
            }
            else
            {
                button1.BackColor = (Color)button1.Tag;
                button2.BackColor = (Color)button2.Tag;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Text = Tag.ToString();
            }
            else
            {

#if caracter
            Text =e.KeyValue.ToString(); //unicode
#else
                Text = e.KeyCode.ToString(); //letra

#endif
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que quere saír?", "Mouse Tester", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}