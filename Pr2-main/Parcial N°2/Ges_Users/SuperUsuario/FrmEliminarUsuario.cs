using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using static Parcial_N_2.Usuarios;

namespace Parcial_N_2.Ges_Users.SuperUsuario
{
    public partial class FrmEliminarUsuario : Form
    {
        // Declaración de variables miembro
        private List<Usuarios> listaUsuarios; // Lista de usuarios
        private string rutaArchivoJson = "C:\\Users\\Public\\Usuarios.json"; // Ruta del archivo JSON

        public FrmEliminarUsuario()
        {
            InitializeComponent();
            CargarUsuariosDesdeJson(); // Llama al método para cargar usuarios desde el archivo JSON al inicializar el formulario
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

        // Maneja el evento del botón "Limpiar" para borrar los campos de entrada
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtUsuario.Clear();
        }

        // Maneja el evento del botón "Eliminar" para eliminar un usuario
        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            string nombreAEliminar = TxtNombre.Text;
            string usuarioAEliminar = TxtUsuario.Text;

            if (string.IsNullOrEmpty(usuarioAEliminar) && string.IsNullOrEmpty(nombreAEliminar))
            {
                MessageBox.Show("Por favor, ingresa el nombre de usuario a eliminar.");
            }
            else
            {
                Usuarios usuarioExistente = listaUsuarios.FirstOrDefault(u => u.Usuario == usuarioAEliminar);

                if (usuarioExistente != null)
                {
                    listaUsuarios.Remove(usuarioExistente);
                    GuardarUsuariosEnJson();
                    MessageBox.Show("Usuario eliminado correctamente.");
                    TxtNombre.Clear();
                    TxtUsuario.Clear();
                }
                else
                {
                    MessageBox.Show("El usuario que intentas eliminar no existe.");
                }
            }
        }

        // Maneja el evento del botón "Salir" para cerrar el formulario actual
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clase interna que representa un usuario con propiedades Usuario y Contrasena
        public class Usuarios
        {
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }
    }
}
