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
        List<string> names;
        List<Cancion> musica;
        List<Cancion> actual;
        Dictionary<string, Cancion> canciones;


        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            canciones = new Dictionary<string, Cancion>();
            musica = new List<Cancion>();
            actual = new List<Cancion>();
            names = new List<string>();
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

                    canciones.Add(cancionActual.Nombre, cancionActual);
                    musica.Add(cancionActual);
                    
                    x++;
                }

                actual = musica;
                MostrarCanciones(actual);
            }
        }

        private void listViewCanciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ruta = actual[listViewCanciones.FocusedItem.Index].Ruta;
  
            WMP.URL = ruta;
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
            if(e.Node.Name == "NodoTituloA")
            {
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Nombre);
                actual = ordenada.ToList();
                MostrarCanciones(actual);

            }

            if(e.Node.Name == "NodoTituloD")
            {
                IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Nombre);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
            }

            if(e.Node.Name == "NodoTamañoA")
            {
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Duracion);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
            }

            if (e.Node.Name == "NodoTamañoD")
            {
                IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Duracion);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
            }

            if (e.Node.Name == "NodoInterprete")
            {
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Interprete);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
            }

            if (e.Node.Name == "NodoAlbum")
            {
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Album);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
            }
        }
    }
}
