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
        List<Cancion> musica;

        public Form1()
        {
            InitializeComponent();           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog BusquedaArchivos = new OpenFileDialog();
            BusquedaArchivos.Multiselect = true;

            if(BusquedaArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] rutas = BusquedaArchivos.FileNames;
                string[] names = BusquedaArchivos.SafeFileNames;

                if (musica == null)
                {
                    musica = new List<Cancion>();
                }

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
                   
                    musica.Add(cancionActual);

                    ListViewItem item = new ListViewItem(cancionActual.Nombre);
                    item.SubItems.Add(cancionActual.Interprete);
                    item.SubItems.Add(cancionActual.Album);
                    item.SubItems.Add(cancionActual.Duracion);

                    listViewCanciones.Items.Add(item);
                    x++;
                }
            }
        }

        private void listViewCanciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WMP.URL = musica[listViewCanciones.FocusedItem.Index].Ruta;
        }
    }
}
