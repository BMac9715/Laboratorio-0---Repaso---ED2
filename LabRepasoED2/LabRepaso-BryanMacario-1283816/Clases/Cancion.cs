using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso_BryanMacario_1283816.Clases
{
    public class Cancion
    {
        private string ruta;
        private string nombre;
        private string interprete;
        private string duracion;
        private string album;

        
        public Cancion()
        {
            this.ruta = string.Empty;
            this.nombre = string.Empty;
            this.interprete = "Desconocido";
            this.duracion = string.Empty;
            this.album = "Desconocido";
        }

        public string Ruta { get => ruta; set => ruta = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Interprete { get => interprete; set => interprete = value; }

        public string Duracion { get => duracion; set => duracion = value; }

        public string Album { get => album; set => album = value; }

        public override string ToString()
        {
            return string.Format("Nombre: {0},\t Interprete: {1},\t Albúm: {2},\t Duración: {3} min", nombre, interprete, album, duracion);
        }
    }
}
