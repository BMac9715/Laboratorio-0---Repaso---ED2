using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso_BryanMacario_1283816.Clases
{
    class ListaReproduccion
    {
        private string nombre;
        private int numero;
        private List<Cancion> canciones;
        private Dictionary<string, Cancion> buscador;

        public ListaReproduccion()
        {
            this.nombre = string.Empty;
            this.canciones = new List<Cancion>();
            this.buscador = new Dictionary<string, Cancion>();
            this.numero = 0;
        }

        public ListaReproduccion(string Nombre)
        {
            this.nombre = Nombre;
            this.canciones = new List<Cancion>();
            this.buscador = new Dictionary<string, Cancion>();
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public List<Cancion> Canciones { get => canciones; set => canciones = value; }

        public Dictionary<string, Cancion> Buscador { get => buscador; set => buscador = value; }

        public int Numero { get => numero; set => numero = value; }

        public void LlenarDiccionario()
        {
            foreach(var element in this.canciones)
            {
                this.buscador.Add(element.Nombre, element);
            }
        }
    }
}
