using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json; // Agregar la referencia a Newtonsoft.Json

namespace Parcial_N_2.Ges_Users.Admin
{
    public partial class FrmLoginAdmin : Form
    {
        // Declaración de variables miembro
        private List<Usuarios> listaUsuarios; // Lista de usuarios
        private string rutaArchivoAdminJson = "C:\\Users\\Public\\Admin.json"; // Ruta del archivo JSON

        public FrmLoginAdmin()
        {
            InitializeComponent();
            CargarUsuariosDesdeJson();
        }

        // Método para cargar usuarios desde el archivo JSON
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
                MessageBox.Show($"Error al cargar usuarios desde el archivo JSON: {ex.Message}");
            }
        }

        // Evento del botón "Entrar" para intentar iniciar sesión como administrador
        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = TxtUsuarioAdmin.Text;
            string contrasenaIngresada = TxtContraseñaAdmin.Text;

            Usuarios usuarioValido = listaUsuarios.FirstOrDefault(u => u.Usuario == usuarioIngresado && u.Contrasena == contrasenaIngresada);

            try
            {
                if (usuarioValido != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");

                    FrmAfterLogin VentAdmin = new FrmAfterLogin();
                    this.Hide();
                    VentAdmin.Show(); // Abre el formulario FrmAfterLogin para el administrador
                }
                else
                {
                    MessageBox.Show("Inicio de sesión fallido. Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("Error: " + c.Message); // Muestra un mensaje en caso de excepción
            }
        }

        // Clase interna que representa un usuario con propiedades Usuario y Contrasena
        public class Usuarios
        {
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }

        // Evento del botón "Salir" para cerrar la aplicación
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
