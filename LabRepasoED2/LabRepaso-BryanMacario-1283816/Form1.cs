using LabRepaso_BryanMacario_1283816.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace LabRepaso_BryanMacario_1283816
{
    public partial class Form1 : Form
    {
        //Listas que almacenaran la información.
        private List<ListaReproduccion> listas;
        private List<Cancion> actual;

        //Conoce la cantidad de listas de reproducción existen.
        private int contador = 0;

        //Representa el indice donde se almacena la lista que actualmente se trabaja
        private int listaActual = 0;

        //Play o Pausa
        private bool play = false;

        public Form1()
        {
            InitializeComponent();

            //Inicializaciones
            listas = new List<ListaReproduccion>();

            //Agrega la lista general, la lista por default.
            listas.Add(new ListaReproduccion("Default"));
            actual = listas[0].Canciones;
            contador = 1;

            //Expande todo el TreeView
            treeView1.ExpandAll();

            //Poseen configuraciones para la interfaz de inicio
            ConfiguracionesIniciales();
        }

        //Funciones de los distintos botones

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog BusquedaArchivos = new OpenFileDialog();

            //Permite la selección de varios elementos
            BusquedaArchivos.Multiselect = true;

            //Filtro de archivos solo de audio
            BusquedaArchivos.Filter = "Archivos de audio|*.mp3;*.wma;*.wav";

            if(BusquedaArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Obtiene la ruta y los nombres de los archivos seleccionados
                string[] rutas = BusquedaArchivos.FileNames;
                List<string> names = BusquedaArchivos.SafeFileNames.ToList();

                int x = 0;

                foreach(var archivo in rutas)
                {
                    //Libreria para obtener mas información del archivo de audio.
                    TagLib.File archivoMp3 = TagLib.File.Create(archivo);
                    Cancion cancionActual = new Cancion();
                    cancionActual.Ruta = archivo;
                    cancionActual.Nombre = names[x];
                    cancionActual.Duracion = archivoMp3.Properties.Duration.Minutes.ToString("#.##")
                                            + ":" + archivoMp3.Properties.Duration.Seconds.ToString("#.##");

                    //Coloca 'Desconocido' si este es null
                    if (archivoMp3.Tag.FirstPerformer != null)
                    {
                        cancionActual.Interprete = archivoMp3.Tag.FirstPerformer;
                    }

                    //Coloca 'Desconocido' si este es null
                    if(archivoMp3.Tag.Album != null)
                    {
                        cancionActual.Album = archivoMp3.Tag.Album;
                    }

                    //Asignación de una canción a la que se este manejando actualmente
                    listas[listaActual].Canciones.Add(cancionActual);
                    listas[listaActual].Buscador.Add(cancionActual.Nombre, cancionActual);
                    
                    x++;
                }

                //Asigna la lista que se maneja actualmente
                actual = listas[listaActual].Canciones;

                //Muestra los archivos cargados en un ListView
                MostrarCanciones(actual);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Verifica que exista algun elemento antes de preguntar si guardara los cambios o no
            if (listBoxMostrar.Items.Count == 0)
            {
                //Configuraciones iniciales

                listViewCanciones.Width = 623;

                listViewCanciones.Columns[0].Width = 225;
                listViewCanciones.Columns[1].Width = 150;
                listViewCanciones.Columns[2].Width = 127;
                listViewCanciones.Columns[3].Width = 116;

                gBCrearLista.Enabled = false;
                gBCrearLista.Visible = false;

            }
            else
            {
                //Pregunta si desea salir sin guardar los cambios
                DialogResult result;
                result = MessageBox.Show("No se han guardado los cambios realizados." +
                                        "\n ¿Seguro que desea salir?", "Advertencia",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    //Configuraciones iniciales...

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
                    //Permanece en la opciones de CrearLista
                    return;
                }
            }


        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            //Abre una pestaña especial para la creación de la lista
            CrearNuevaLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Verifica que exista un elemento seleccionado de la ListView
            if (listViewCanciones.FocusedItem != null)
            {
                //Obtiene los indices de todos los elementos seleccionados...
                ListView.SelectedIndexCollection indices = listViewCanciones.SelectedIndices;

                //Comprueba si es necesario crear la lista o si esta ya esta creada...
                if (listas.Count() == contador)
                {
                    listas.Add(new ListaReproduccion());
                }

                foreach (int i in indices)
                {
                    //Agrega a la nueva lista los elementos que se seleccionaron
                    listas[contador].Canciones.Add(listas[0].Canciones[i]);
                    listas[contador].Buscador.Add(listas[0].Canciones[i].Nombre, listas[0].Canciones[i]);
                    listBoxMostrar.Items.Add(listas[0].Canciones[i].Nombre);
                }

                //Activa los botones Guardar y Quitar
                btnGuardar.Enabled = true;
                btnQuitar.Enabled = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            foreach(var elemento in listas)
            {
                if (txtNombre.Text == elemento.Nombre)
                {
                    //Si dejo el nombre por defecto le agrega un número que representa el
                    //numero de lista con ese nombre
                    listas[contador].Nombre = txtNombre.Text + contador.ToString();
                    listas[contador].Numero = contador;

                    //Agrega un nodo para visualizar la nueva lista en el TreeView
                    TreeNode nuevo = new TreeNode();

                    //Configura Nombre y Texto de este nuevo nodo
                    nuevo.Text = listas[contador].Nombre;
                    nuevo.Name = listas[contador].Nombre;
                    treeView1.Nodes[0].Nodes.Add(nuevo);
                }
                else
                {
                    //Si el usuario cambio el nombre, solo lo almacena
                    listas[contador].Nombre = txtNombre.Text;
                    listas[contador].Numero = contador;

                    //Agrega un nodo para visualizar la nueva lista en el TreeView
                    TreeNode nuevo = new TreeNode();

                    //Configura Nombre y Texto de este nuevo nodo
                    nuevo.Text = listas[contador].Nombre;
                    nuevo.Name = listas[contador].Nombre;
                    treeView1.Nodes[0].Nodes.Add(nuevo);
                }
            }
            //Verifica si el usuario cambio el texto o si dejo el nombre por defecto
            

            contador++;
            ConfiguracionesIniciales();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //Este boton pertenece a la sección de Crear Nueva Lista

            //Obtiene los indices de los elementos seleccionados en el List Box
            ListBox.SelectedIndexCollection indices = listBoxMostrar.SelectedIndices;

            foreach (int i in indices)
            {
                //Retira de la lista los elementos seleccionados
                listas[contador].Canciones.RemoveAt(i);
                listas[contador].Buscador.Remove(listBoxMostrar.Items[i].ToString());
                listBoxMostrar.Items.RemoveAt(i);
            }

            //Desactiva los botones Quitar y Guardar si no existe ningun elemento en la lista
            if (listBoxMostrar.Items.Count == 0)
            {
                btnQuitar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Este boton pertenece a la sección principal

            //Verifica si existe algun elemento seleccionado
            if (listViewCanciones.FocusedItem != null)
            {
                //Obtiene los indices de las canciones seleccionadas del ListView
                ListView.SelectedIndexCollection indices = listViewCanciones.SelectedIndices;

                foreach (int i in indices)
                {
                    //Retira las canciones seleccionadas de la lista correspondiente
                    Cancion temp = listas[listaActual].Buscador[listViewCanciones.Items[i].Text];
                    listas[listaActual].Buscador.Remove(listViewCanciones.Items[i].Text);
                    listas[listaActual].Canciones.Remove(temp);
                    listViewCanciones.Items.RemoveAt(i);
                }
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Verifica que existan elementos ya agregados a la lista
            if (listViewCanciones.Items.Count != 0)
            {
                //Comprueba si selecciono otra cancion
                if (WMP.URL == actual[listViewCanciones.FocusedItem.Index].Ruta)
                {
                    //Continua con la reproducción de la cancion donde se haya pausado
                    WMP.Ctlcontrols.play();
                    play = true;
                }
                else
                {
                    //Inicia la reproducción de la canción desde cero
                    ReproducirCancion();
                    play = true;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Detiene la reproducción de la canción
            WMP.Ctlcontrols.stop();
            play = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (listViewCanciones.Items.Count != 0)
            {
                if (play == true)
                {
                    //Detiene la reproducción de la canción, para poder continuarla despues.
                    WMP.Ctlcontrols.pause();
                    play = false;
                }
            }
        }


        //Funciones de la ListView

        private void listViewCanciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Reproduce la canción que se haya clickeado dos veces...
            ReproducirCancion();
        }


        //Funciones de el TreeView

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Verifica si no se ha seleccionado una lista de reproducción
            foreach (var element in listas)
            {
                if (e.Node.Name == element.Nombre)
                {
                    listaActual = element.Numero;
                    actual = element.Canciones;
                    MostrarCanciones(actual);
                    return;
                }
            }

            //Sucede cuando presiona el nodo Todas las canciones
            if (e.Node.Name == "NodoTodo")
            {
                //Muestra la lista general en el ListView
                listaActual = 0;
                actual = listas[0].Canciones;
                MostrarCanciones(actual);
                return;
            }

            //Sucede cuando presiona el nodo Musica->Nombre->Ascendente
            if (e.Node.Name == "NodoTituloA")
            {
                //Ordena la lista Actual en base al nombre de forma ascendente
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Nombre);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            //Sucede cuando presiona el nodo Musica->Nombre->Descendente
            if (e.Node.Name == "NodoTituloD")
            {
                //Ordena la lista Actual en base al nombre de forma descendente
                IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Nombre);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            //Sucede cuando presiona el nodo Musica->Duracion->Ascendente
            if (e.Node.Name == "NodoTamañoA")
            {
                //Ordena la lista Actual en base a la duración de la canción de forma ascendente
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Duracion);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            //Sucede cuando presiona el nodo Musica->Duracion->Descendente
            if (e.Node.Name == "NodoTamañoD")
            {
                //Ordena la lista Actual en base a la duración de la canción de forma descendente
                IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Duracion);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            //Sucede cuando presiona el nodo Musica->Interprete
            if (e.Node.Name == "NodoInterprete")
            {
                //Ordena la lista Actual en base al nombre del interprete de la canción de forma descendente
                IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Interprete);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

            //Sucede cuando presiona el nodo Musica->Album
            if (e.Node.Name == "NodoAlbum")
            {
                //Ordena la lista Actual en base al nombre del album de la canción 
                IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Album);
                actual = ordenada.ToList();
                MostrarCanciones(actual);
                return;
            }

        }


        //Funciones para el manejo del audio y la interfaz de reproducción

        public void ActualizarDatosTrack()
        {
            if (WMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Control de tiempo máximo del mp3 actual
                macTrackStatus.Maximum = (int)WMP.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (WMP.playState == WMPLib.WMPPlayState.wmppsPaused)
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


        //Funciones del StripMenu

        private void agregarMúsicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog BusquedaArchivos = new OpenFileDialog();
            BusquedaArchivos.Multiselect = true;
            BusquedaArchivos.Filter = "Archivos de audio|*.mp3;*.wma;*.wav";

            if (BusquedaArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] rutas = BusquedaArchivos.FileNames;
                List<string> names = BusquedaArchivos.SafeFileNames.ToList();

                int x = 0;

                foreach (var archivo in rutas)
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


                    if (archivoMp3.Tag.Album != null)
                    {
                        cancionActual.Album = archivoMp3.Tag.Album;
                    }

                    listas[listaActual].Canciones.Add(cancionActual);
                    listas[listaActual].Buscador.Add(cancionActual.Nombre, cancionActual);

                    x++;
                }

                actual = listas[listaActual].Canciones;
                MostrarCanciones(actual);
            }
        }

        private void crearListaDeReproduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearNuevaLista();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Nombre);
            actual = ordenada.ToList();
            MostrarCanciones(actual);
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Nombre);
            actual = ordenada.ToList();
            MostrarCanciones(actual);
        }

        private void ascendenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Duracion);
            actual = ordenada.ToList();
            MostrarCanciones(actual);
        }

        private void descendenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IEnumerable<Cancion> ordenada = actual.OrderByDescending(obj => obj.Duracion);
            actual = ordenada.ToList();
            MostrarCanciones(actual);
        }

        private void interpreteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Interprete);
            actual = ordenada.ToList();
            MostrarCanciones(actual);
        }

        private void albúmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<Cancion> ordenada = actual.OrderBy(obj => obj.Album);
            actual = ordenada.ToList();
            MostrarCanciones(actual);
        }

        private void acercaDelSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este software ha sido desarrollado como una práctica del" +
                            "\ncurso de estructuras de datos II de la carrera de Ingenieria" +
                            "\nen Informatica y Sistemas." +
                            "\n\nDesarrollado por el alumno: Bryan Macario.", "Reproductor MP3", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Funciones de TextBox's

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            //Selecciona todo el texto dentro del TextBox
            txtNombre.SelectAll();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Al Presionar 'Enter' se dirige a la función
            if (e.KeyChar == (char)13)
            {
                Search(txtBusqueda.Text);
            }

        }

        private void txtBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            //Limpia el TextBox cuando se presiona click
            txtBusqueda.Text = "";
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //Si el texto esta vacio, se muestra la lista en la cual se esta actualmente
            if (txtBusqueda.Text == "")
            {
                actual = listas[listaActual].Canciones;
                MostrarCanciones(actual);
            }
        }


        //Funciones agregadas para el funcionamiento del programa

        private void ReproducirCancion()
        {
            //Obtiene la ruta del elemento seleccionado
            string ruta = actual[listViewCanciones.FocusedItem.Index].Ruta;
            //Inicia la reproducción del elemento
            WMP.URL = ruta;  
            //Muestra el nombre de la canción que se reproduce actualmente
            labelCancion.Text = actual[listViewCanciones.FocusedItem.Index].Nombre;
        }

        private void MostrarCanciones(List<Cancion> lista)
        {   
            //Muestra los elementos de una lista en el ListView
            ListViewItem item;
            listViewCanciones.Items.Clear();

            foreach (var elemento in lista)
            {
                //Agrega la información a mostrar en cada registro
                item = new ListViewItem(elemento.Nombre);

                item.SubItems.Add(elemento.Interprete);
                item.SubItems.Add(elemento.Album);
                item.SubItems.Add(elemento.Duracion);

                listViewCanciones.Items.Add(item);
            }
        }

        private void CrearNuevaLista()
        {
            //Se coloca en la lista general y la muestra
            actual = listas[0].Canciones;
            MostrarCanciones(actual);

            //Configura la interfaz para la pestaña Crear Lista
            ConfiguracionesCrearNuevaLista();

            //Ventana de información
            MessageBox.Show("Para agregar canciones a la nueva lista  de reproducción," +
                            "\npor favor seleccione las canciones de la biblioteca y " +
                           "\nluego presione el boton 'Agregar'." +
                           "\nPuede seleccionar varios elementos a la vez, debe mantener" +
                           "\npresionado 'ctrl' y clickear sobre las canciones deseadas.", "Nueva lista de reproducción",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Coloca el foco sobre el TextBox del nombre de la lista
            txtNombre.Focus();
            txtNombre.SelectAll();
        }

        private void ConfiguracionesIniciales()
        {
            //Configuraciones originales de la ventana solo cambiara cuando se invoque
            //la función Crear Lista
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
            //Configuraciones necesarias para mostrar la nueva pestaña
            txtNombre.Text = "NuevaLista";

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

        private void Search(string nombre)
        {
            //Realiza la busqueda de la canción en la lista que se encuentra actualmente
            try
            {
                Cancion temp = listas[listaActual].Buscador[nombre];

                listViewCanciones.Items.Clear();

                ListViewItem item = new ListViewItem(nombre);

                item.SubItems.Add(temp.Interprete);
                item.SubItems.Add(temp.Album);
                item.SubItems.Add(temp.Duracion);

                //Si el elemento buscado se encuentra en la lista, se muestra en el ListView
                listViewCanciones.Items.Add(item);
                actual = new List<Cancion>();
                actual.Add(temp);
            }
            catch (Exception e)
            {
                //Mesaje de error al buscar el elemento
                MessageBox.Show("No se ha encontrado la canción deseada. " +
                                "\nRecuerde que debe ingresar el nombre tal y como se encuentra almacenado." +
                                "\nEjemplo: 'MiCancion.mp3'", "Busqueda No Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
