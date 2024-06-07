using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Parcial_N_2.Usuarios;

namespace Parcial_N_2
{
    public partial class FrmModfUsuarios : Form
    {
        // Declaración de variables miembro
        private List<Usuarios> listaUsuarios;   // Lista de usuarios
        private string rutaArchivoJson = "C:\\Users\\Public\\Usuarios.json"; // Ruta del archivo JSON

        public FrmModfUsuarios()
        {
            InitializeComponent();
            CargarUsuariosDesdeJson(); // Llama al método para cargar usuarios desde el archivo JSON
        }

        // Evento del botón "Salir" para cerrar el formulario
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para cargar usuarios desde el archivo JSON
        private void CargarUsuariosDesdeJson()
        {
            try
            {
                if (File.Exists(rutaArchivoJson))
                {
                    string contenidoJson = File.ReadAllText(rutaArchivoJson);
                    listaUsuarios = JsonConvert.DeserializeObject<List<Usuarios>>(contenidoJson);
                }
                else
                {
                    listaUsuarios = new List<Usuarios>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios desde el archivo JSON: {ex.Message}");
            }
        }

        // Método para guardar usuarios en el archivo JSON
        private void GuardarUsuariosEnJson()
        {
            try
            {
                string nuevoContenidoJson = JsonConvert.SerializeObject(listaUsuarios, Formatting.Indented);
                File.WriteAllText(rutaArchivoJson, nuevoContenidoJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuarios en el archivo JSON: {ex.Message}");
            }
        }

        // Evento del botón "Registrar" para modificar un usuario
        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            string nombreAModificar = TxtNombre.Text;
            string usuarioAModificar = TxtUsuario.Text;

            if (string.IsNullOrEmpty(usuarioAModificar) && string.IsNullOrEmpty(nombreAModificar))
            {
                MessageBox.Show("Por favor, ingresa el nombre de usuario a modificar.");
            }
            else
            {
                Usuarios usuarioExistente = listaUsuarios.FirstOrDefault(u => u.Usuario == usuarioAModificar);

                if (usuarioExistente != null)
                {
                    string nuevaContrasena = TxtNuevaContraseña.Text;

                    if (!string.IsNullOrEmpty(nuevaContrasena))
                    {
                        usuarioExistente.Contrasena = nuevaContrasena;
                        GuardarUsuariosEnJson(); // Guarda la lista actualizada en el archivo JSON
                        MessageBox.Show("Usuario modificado correctamente.");
                        TxtNombre.Clear();
                        TxtUsuario.Clear();
                        TxtContraseña.Clear();
                        TxtNuevaContraseña.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingresa una nueva contraseña para el usuario.");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario que intentas modificar no existe.");
                }
            }
        }

        // Evento del botón "Limpiar" para borrar los campos de texto
        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtUsuario.Clear();
            TxtContraseña.Clear();
        }

        // Clase interna que representa un usuario con propiedades Nombre, Usuario y Contrasena
        public class Usuarios
        {
            public string Nombre { get; set; }
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }
    }
}
