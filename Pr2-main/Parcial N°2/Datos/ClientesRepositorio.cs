using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_N_2.Datos
{
    internal class ClientesRepositorio
    {
        private const string RUTA_FICHERO_EMPLEADO = @"C:\Users\Public\Clientes.json";
        public static List<Clientes> clientes { get; set; }

        public static void IniciarRepositorio()
        {
            if (File.Exists(RUTA_FICHERO_EMPLEADO))
            {
                string json = File.ReadAllText(RUTA_FICHERO_EMPLEADO);
                clientes = JsonConvert.DeserializeObject<List<Clientes>>(json);
            }
            else{
                clientes = new List<Clientes>();
            }
           
        }

        public static void AñadirClientes(Clientes clientesC)
        {
            clientes.Add(clientesC);
            string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADO, json);
        }

        public static void ElminiarCliente(string cedula)
        {
            clientes.RemoveAll(e =>e.Cedula.Equals(cedula));
            string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADO, json);
        }

        public static void ModificarCliente(string ClienteOrigen, Clientes clienteModificado)
        {
            int indexClienteOriginal = clientes.FindIndex(e => e.Cedula == ClienteOrigen);

            if (indexClienteOriginal != -1)
            {
                clientes[indexClienteOriginal] = clienteModificado;
            }
            string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADO, json);
        }
    }
}
