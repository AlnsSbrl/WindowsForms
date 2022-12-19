using System.Collections;
using System.Diagnostics;
using TraspasaListas.Properties;

namespace TraspasaListas
{
    public partial class Form1 : Form
    {
        int cont = 1;
        string tituloVacio;
        //string titulo = "
        string titulo = "All the lonely people, Where do they all come from?";
        bool estaEscribiendoElNombre=false;
        int contadorTitulo;
        int numLetraEscribir=0;
        public Form1()
        {
            InitializeComponent();
            ActualizarListas();
            //this.Icon = Resources.icono1;
            timer1.Start();
            //con this.width me sale algo PEQUEÑISIMO
            int ancho = titulo.Length;
            tituloVacio = new string(' ', ancho);
            Text = tituloVacio;
            contadorTitulo= titulo.Length;
            labelListProtegida.Text = "Ningun elemento seleccionado";
        }

        public void ActualizarListas()
        {
            labelList1.Text = listElementos.Items.Count.ToString();
            if(listElementos.SelectedIndices.Count == 0)
            {
                labelListProtegida.Text = "Ningun elemento seleccionado";
            }
            toolTip1.SetToolTip(listElementosProtegidos, listElementosProtegidos.Items.Count.ToString());
        }
        private void BtnEngadir_Click(object sender, EventArgs e)
        {
            if (txbNuevoElemento.Text != "" && listElementos.Items.IndexOf(txbNuevoElemento.Text)==-1)
            {
                listElementos.Items.Add(txbNuevoElemento.Text);
                txbNuevoElemento.Text = "";
            }
            ActualizarListas();
        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            if(sender==btnTraspasarToRight && listElementos.SelectedItem != null)
            {
                ArrayList arrayList = new ArrayList();
                List<ListBox.ObjectCollection> list = new List<ListBox.ObjectCollection>(); 
                for (int i = listElementos.Items.Count-1; i >=0 ; i--)
                {
                    if (listElementos.GetSelected(i))
                    {
                        arrayList.Add(listElementos.Items[i]);
                       
                        listElementos.Items.RemoveAt(i);                       
                    }
                }
                arrayList.Reverse();
                object[] newItems = arrayList.ToArray();
                listElementosProtegidos.Items.AddRange(newItems);
            }
            if(sender==btnTraspasarToLeft && listElementosProtegidos.SelectedItem != null)
            {
                for (int i = listElementosProtegidos.Items.Count-1; i >= 0; i--)
                {
                    if (listElementosProtegidos.GetSelected(i))
                    {
                        listElementos.Items.Add(listElementosProtegidos.Items[i]);
                        listElementosProtegidos.Items.RemoveAt(i);
                    }
                }
            }
            ActualizarListas();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (estaEscribiendoElNombre)
            {
                numLetraEscribir++;
                Text = Text.Substring(1, Text.Length - 1) + titulo[numLetraEscribir];
                if(numLetraEscribir == titulo.Length-1)
                {
                    estaEscribiendoElNombre = false;
                }
            }
            else if (this.Text.Trim(' ') == "")
            {
                estaEscribiendoElNombre = true;
                numLetraEscribir = 0;
                Text = Text.Substring(1, Text.Length - 1) + titulo[numLetraEscribir];
            }
            else
            {
                this.Text=this.Text.Substring(1,this.Text.Length-1)+" ";
            }
            if (cont % 2 == 0)
            {
                Icon = Resources.icono1;
            }
            else
            {
                Icon = Resources.icono3;
            }
            cont++;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = listElementos.Items.Count-1; i >=0 ; i--)
            {
                if (listElementos.GetSelected(i))
                {
                    listElementos.Items.RemoveAt(i);
                }
            }
            ActualizarListas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void listElementos_Click(object sender, EventArgs e)
        {
            labelListProtegida.Text = "Seleccionados: ";
            for (int i = 0; i < listElementos.Items.Count; i++)
            {
                if (listElementos.GetSelected(i))
                {
                    labelListProtegida.Text+= " "+i+" ";
                }
            }
        }
    }
}