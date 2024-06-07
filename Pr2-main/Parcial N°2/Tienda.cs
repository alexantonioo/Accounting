using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_N_2
{
    public class Tienda
    {
        private string _nombre;
        private string _rif;
        private string _correo;
        private string _telefono;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Rif { get { return _rif; } set { _rif = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }

        public Tienda()
        {
            Nombre = string.Empty;
            Rif = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
        }

        public Tienda(string nombre, string rif, string correo, string telefono)
        {
            Nombre = nombre;
            Rif = rif;
            Correo = correo;
            Telefono = telefono;
        }

        public string MostrarDatosTienda()
        {
            return $"{Nombre} \n Rif:  { Rif} \n Tlf:  {Telefono}";
        }
    }
}
