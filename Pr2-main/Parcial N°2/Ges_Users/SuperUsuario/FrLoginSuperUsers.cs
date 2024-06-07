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

namespace Parcial_N_2.Ges_Users.SuperUsuario
{
    public partial class FrLoginSuperUsers : Form
    {
        // Declaración de variables miembro
        private List<Usuarios> listaUsuarios;   // Lista de usuarios
        private string rutaArchivoSuperUserJson = "C:\\Users\\Public\\SuperUsuarios.json"; // Ruta del archivo JSON

        public FrLoginSuperUsers()
        {
            InitializeComponent();
            CargarUsuariosDesdeJson(); // Llama al método para cargar usuarios desde el archivo JSON
        }

        // Método para cargar usuarios desde el archivo JSON
        private void CargarUsuariosDesdeJson()
        {
            try
            {
                if (File.Exists(rutaArchivoSuperUserJson))
                {
                    string contenidoJson = File.ReadAllText(rutaArchivoSuperUserJson);
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

        // Evento del botón "Entrar" para intentar iniciar sesión
        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = TxtUsuarioSU.Text;
            string contrasenaIngresada = TxtContraseñaSU.Text;

            Usuarios usuarioValido = listaUsuarios.FirstOrDefault(u => u.Usuario == usuarioIngresado && u.Contrasena == contrasenaIngresada);

            try
            {
                if (usuarioValido != null)
                {
                    File.ReadAllText(rutaArchivoSuperUserJson);

                    MessageBox.Show("Inicio de sesión exitoso.");

                    FrmAfterLoginSupUser VentSuperUser = new FrmAfterLoginSupUser();
                    this.Hide();  // Oculta el formulario de inicio de sesión
                    VentSuperUser.Show();  // Muestra el formulario de SuperUsuario
                }
                else
                {
                    MessageBox.Show("Inicio de sesión fallido. Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("Error" + c);
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
