using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRepaso_BryanMacario_1283816.Clases
{
    public class Cancion
    {
        string ruta;
        string nombre;
        string interprete;
        string duracion;
        string album;

        
        public Cancion()
        {
            ruta = string.Empty;
            nombre = string.Empty;
            interprete = "Desconocido";
            duracion = string.Empty;
            album = "Desconocido";
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
