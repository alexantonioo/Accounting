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
using Newtonsoft.Json;


namespace Parcial_N_2
{
    public partial class FrmLoginUsuario : Form
    {
        // Declaración de variables miembro
        private List<Usuarios> listaUsuarios; // Lista de usuarios
        private string rutaArchivoJson = "C:\\Users\\Public\\Usuarios.json"; // Ruta del archivo JSON

        public FrmLoginUsuario()
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

        // Maneja el evento del botón "Entrar" para el inicio de sesión
        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = TxtUsuario.Text;
            string contrasenaIngresada = TxtContraseña.Text;

            Usuarios usuarioValido = listaUsuarios.FirstOrDefault(u => u.Usuario == usuarioIngresado && u.Contrasena == contrasenaIngresada);

            try
            {
                if (usuarioValido != null)
                {
                    Menu VentMenu = new Menu();
                    this.Hide();
                    VentMenu.Show();

                    MessageBox.Show("Inicio de sesión exitoso.");
                }
                else
                {
                    MessageBox.Show("Inicio de sesión fallido. Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("Error: " + c.Message);
            }
        }

        // Maneja el evento del botón "Salir" para cerrar la aplicación
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Clase interna que representa un usuario con propiedades Usuario y Contrasena
        public class Usuarios
        {
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }
    }
}

