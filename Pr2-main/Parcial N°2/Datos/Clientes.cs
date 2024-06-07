using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_N_2.Datos
{
    public class Clientes
    {
        public string Cedula { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Pais { get; private set; }
        public string Estado { get; private set; }
        public string Ciudad { get; private set; }
        public string Telefono { get; private set; }
        public string Correo { get; private set; }

        public Clientes(string cedula, string nombre, string apellido, string pais, string estado, string ciudad, string telefono, string correo)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;  
            this.Estado = estado;
            this.Ciudad = ciudad;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Pais = pais;
            
        }

    }
}
