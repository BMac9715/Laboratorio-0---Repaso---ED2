using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TagLib;
using System.Windows.Forms;
using LabRepaso_BryanMacario_1283816.Clases;


namespace LabRepaso_BryanMacario_1283816
{
    public partial class Form1 : Form
    {
        private List<string> names;
        private List<ListaReproduccion> listas;
        private List<Cancion> actual;
        private int contador = 0;
        private int listaActual = 0;
        private bool play = false;

        public Form1()
        {
            InitializeComponent();
            listas = new List<ListaReproduccion>();
            listas.Add(new ListaReproduccion("Default"));
            actual = listas[0].Canciones;
            names = new List<string>();
            contador = 1;
            ConfiguracionesIniciales();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog BusquedaArchivos = new OpenFileDialog();
            BusquedaArchivos.Multiselect = true;
            BusquedaArchivos.Filter = "Archivos de audio|*.mp3;*.wma;*.wav";

            if(BusquedaArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string[] rutas = BusquedaArchivos.FileNames;
                names = BusquedaArchivos.SafeFileNames.ToList();

                int x = 0;

                foreach(var archivo in rutas)
                {
                    TagLib.File archivoMp3 = TagLib.File.Create(archivo);
                    Cancion cancionActual = new Cancion();
                    cancionActual.Ruta = archivo;
                    cancionActual.Nombre = names[x];
                    cancionActual.Duracion = archivoMp3.Properties.Duration.Minutes.ToString("#.##")
                                            + ":" + archivoMp3.Properties.Duration.Seconds.ToString("#.##");

                    if (archivoMp3.Tag.FirstPerformer != null)
                    {
                        cancionActual.Interprete = archivoMp3.Tag.FirstPerformer;
                    }

                    
                    if(archivoMp3.Tag.Album != null)
                    {
                        cancionActual.Album = archivoMp3.Tag.Album;
                    }

                    listas[listaActual].Canciones.Add(cancionActual);
                    
                    x++;
                }

                actual = listas[listaActual].Canciones;
                MostrarCanciones(actual);
            }
        }

        private void listViewCanciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            string ruta = actual[listViewCanciones.FocusedItem.Index].Ruta;
            WMP.URL = ruta;
            btnPlay.Image = Properties.Resources.boton_redondo_de_pausa;
            labelCancion.Text = actual[listViewCanciones.FocusedItem.Index].Nombre;
        }

        private void MostrarCanciones(List<Cancion> lista)
        {          
            ListViewItem item;
            listViewCanciones.Items.Clear();

            foreach (var elemento in lista)
            {
                item = new ListViewItem(elemento.Nombre);

                item.SubItems.Add(elemento.Interprete);
                item.SubItems.Add(elemento.Album);
                item.SubItems.Add(elemento.Duracion);

                listViewCanciones.Items.Add(item);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach(var element in listas)
            {
                if(e.Node.Name == element.Nombre)
                {
                    listaActual = element.Numero;
                    actual = element.Canciones;
                    MostrarCanciones(actual);
                    return;
                }
            }

            if (e.Node.Name == "NodoTodo")
            {
                listaActual = 0;
                actual = listas[0].Canciones;  
                MostrarCanciones(actual);
                return;
            }

            if (e.Node.Name == "NodoTituloA")
            {
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Nombre);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            if (e.Node.Name == "NodoTituloD")
            {
                IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Nombre);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            if(e.Node.Name == "NodoTamañoA")
            {
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Duracion);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            if (e.Node.Name == "NodoTamañoD")
            {
                IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Duracion);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            if (e.Node.Name == "NodoInterprete")
            {
                IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Interprete);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            if (e.Node.Name == "NodoAlbum")
            {
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Album);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }
            
        }

        private void CrearNuevaLista()
        {
            actual = listas[0].Canciones;
            MostrarCanciones(actual);

            ConfiguracionesCrearNuevaLista();

            MessageBox.Show("Para agregar canciones a la nueva lista  de reproducción," +
                            "\npor favor seleccione las canciones de la biblioteca y " +
                           "\nluego presione el boton 'Agregar'." +
                           "\nPuede seleccionar varios elementos a la vez, debe mantener" +
                           "\npresionado 'ctrl' y clickear sobre las canciones deseadas.", "Nueva lista de reproducción", 
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Focus();
            txtNombre.SelectAll();
        }

        private void ConfiguracionesIniciales()
        {
            listViewCanciones.Width = 623;

            listViewCanciones.Columns[0].Width = 225;
            listViewCanciones.Columns[1].Width = 150;
            listViewCanciones.Columns[2].Width = 127;
            listViewCanciones.Columns[3].Width = 116;

            gBCrearLista.Enabled = false;
            gBCrearLista.Visible = false;
        }

        private void ConfiguracionesCrearNuevaLista()
        {
            listViewCanciones.Width = 445;
            listViewCanciones.Columns[0].Width = 165;
            listViewCanciones.Columns[1].Width = 100;
            listViewCanciones.Columns[2].Width = 85;
            listViewCanciones.Columns[3].Width = 90;

            listBoxMostrar.Items.Clear();

            gBCrearLista.Enabled = true;
            gBCrearLista.Visible = true;
            btnGuardar.Enabled = false;
            btnQuitar.Enabled = false;
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            txtNombre.SelectAll();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            if(listBoxMostrar.Items.Count == 0)
            {
                listViewCanciones.Width = 623;

                listViewCanciones.Columns[0].Width = 225;
                listViewCanciones.Columns[1].Width = 150;
                listViewCanciones.Columns[2].Width = 127;
                listViewCanciones.Columns[3].Width = 116;

                gBCrearLista.Enabled = false;
                gBCrearLista.Visible = false;

                listas[contador] = null;
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("No se han guardado los cambios realizados." +
                                        "\n ¿Seguro que desea salir?", "Advertencia",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if(result == System.Windows.Forms.DialogResult.OK)
                {
                    listViewCanciones.Width = 623;

                    listViewCanciones.Columns[0].Width = 225;
                    listViewCanciones.Columns[1].Width = 150;
                    listViewCanciones.Columns[2].Width = 127;
                    listViewCanciones.Columns[3].Width = 116;

                    gBCrearLista.Enabled = false;
                    gBCrearLista.Visible = false;

                    listas.RemoveAt(contador);
                }
                else
                {
                    return;
                }
            }

            
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            CrearNuevaLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                      
            if(listViewCanciones.FocusedItem != null)
            {
                ListView.SelectedIndexCollection indices = listViewCanciones.SelectedIndices;

                if(listas.Count() == contador)
                {
                    listas.Add(new ListaReproduccion());
                }
                
                foreach(int i in indices)
                {
                    listas[contador].Canciones.Add(listas[0].Canciones[i]);
                    listas[contador].Buscador.Add(listas[0].Canciones[i].Nombre, listas[0].Canciones[i]);
                    listBoxMostrar.Items.Add(listas[0].Canciones[i].Nombre);
                }

                btnGuardar.Enabled = true;
                btnQuitar.Enabled = true;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "NuevaLista")
            {
                listas[contador].Nombre = txtNombre.Text + contador.ToString();
                listas[contador].Numero = contador;

                TreeNode nuevo = new TreeNode();

                nuevo.Text = listas[contador].Nombre;
                nuevo.Name = listas[contador].Nombre;
                treeView1.Nodes[0].Nodes.Add(nuevo);
            }
            else
            {
                listas[contador].Nombre = txtNombre.Text;
                listas[contador].Numero = contador;

                TreeNode nuevo = new TreeNode();

                nuevo.Text = listas[contador].Nombre;
                nuevo.Name = listas[contador].Nombre;
                treeView1.Nodes[0].Nodes.Add(nuevo);             
            }
            
            contador++;
            ConfiguracionesIniciales();       
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = listBoxMostrar.SelectedIndices;

            foreach(int i in indices)
            {
                listas[contador].Canciones.RemoveAt(i);
                listas[contador].Buscador.Remove(listBoxMostrar.Items[i].ToString());
                listBoxMostrar.Items.RemoveAt(i);
            }

            if(listBoxMostrar.Items.Count == 0)
            {
                btnQuitar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listViewCanciones.FocusedItem != null)
            {
                ListView.SelectedIndexCollection indices = listViewCanciones.SelectedIndices;

                foreach (int i in indices)
                {
                    listas[listaActual].Buscador.Remove(listas[listaActual].Canciones[i].Nombre);
                    listas[listaActual].Canciones.RemoveAt(i);                
                    listViewCanciones.Items.RemoveAt(i);
                }
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch(play)
            {
                case true:
                    WMP.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.boton_de_reproduccion;
                    play = false;
                    break;

                case false:
                    WMP.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.boton_redondo_de_pausa;
                    play = true;
                    break;

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.boton_de_reproduccion;
            play = false;
        }

        public void ActualizarDatosTrack()
        {
            if(WMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Control de tiempo máximo del mp3 actual
                macTrackStatus.Maximum = (int)WMP.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if(WMP.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (WMP.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                macTrackStatus.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            macTrackStatus.Value = (int)WMP.Ctlcontrols.currentPosition;
            macTrackVolumen.Value = WMP.settings.volume;
        }

        private void WMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private void macTrackVolumen_ValueChanged(object sender, decimal value)
        {
            WMP.settings.volume = macTrackVolumen.Value;
        }
    }
}
