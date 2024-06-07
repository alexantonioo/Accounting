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

namespace Parcial_N_2.Ges_Users.SuperUsuario
{
    public partial class FrmModifAdmin : Form
    {
        // Declaración de variables miembro
        private List<Usuarios> listaUsuarios; // Lista de administradores
        private string rutaArchivoAdminJson = "C:\\Users\\Public\\Admin.json"; // Ruta del archivo JSON

        public FrmModifAdmin()
        {
            InitializeComponent();
            CargarUsuariosDesdeJson(); // Llama al método para cargar administradores desde el archivo JSON al inicializar el formulario
        }

        // Método para cargar administradores desde el archivo JSON
        private void CargarUsuariosDesdeJson()
        {
            try
            {
                if (File.Exists(rutaArchivoAdminJson))
                {
                    string contenidoJson = File.ReadAllText(rutaArchivoAdminJson);
                    listaUsuarios = JsonConvert.DeserializeObject<List<Usuarios>>(contenidoJson);
                }
                else
                {
                    listaUsuarios = new List<Usuarios>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar administradores desde el archivo JSON: {ex.Message}");
            }
        }

        // Método para guardar administradores en el archivo JSON
        private void GuardarUsuariosEnJson()
        {
            try
            {
                string nuevoContenidoJson = JsonConvert.SerializeObject(listaUsuarios, Formatting.Indented);
                File.WriteAllText(rutaArchivoAdminJson, nuevoContenidoJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar administradores en el archivo JSON: {ex.Message}");
            }
        }

        // Maneja el evento del botón "Modificar" para cambiar la contraseña de un administrador
        private void Btn_Modificar_Click(object sender, EventArgs e)
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
                        GuardarUsuariosEnJson();
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

        // Maneja el evento del botón "Limpiar" para borrar los campos de entrada
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtUsuario.Clear();
            TxtContraseña.Clear();
        }

        // Maneja el evento del botón "Salir" para cerrar el formulario actual
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clase interna que representa un administrador con propiedades Usuario y Contrasena
        public class Usuarios
        {
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }
    }
}
