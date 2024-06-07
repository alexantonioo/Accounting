using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace Parcial_N_2
{
    public partial class FrmRegistro : Form
    {
        // Declaración de variables miembro
        private List<Usuarios> listaUsuarios;   // Lista de usuarios
        private string rutaArchivoJson = "C:\\Users\\Public\\Usuarios.json"; // Ruta del archivo JSON

        public FrmRegistro()
        {
            InitializeComponent();
            CargarUsuariosDesdeJson(); // Llama al método para cargar usuarios desde el archivo JSON
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

        // Evento del botón "Limpiar" para borrar los campos de texto
        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtUsuario.Clear();
            TxtContraseña.Clear();
        }

        // Evento del botón "Registrar" para registrar un nuevo usuario
        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = TxtUsuario.Text;
            string nuevaContrasena = TxtContraseña.Text;
            string nuevoNombre = TxtNombre.Text;

            if (!string.IsNullOrEmpty(nuevoUsuario) && !string.IsNullOrEmpty(nuevaContrasena) && !string
                .IsNullOrEmpty(nuevoNombre))
            {
                if (listaUsuarios.Any(u => u.Usuario == nuevoUsuario))
                {
                    MessageBox.Show("El usuario ya existe. Elige otro nombre de usuario.");
                }
                else
                {
                    listaUsuarios.Add(new Usuarios { Nombre = nuevoNombre, Usuario = nuevoUsuario, Contrasena = nuevaContrasena });
                    GuardarUsuariosEnJson();
                    MessageBox.Show("Usuario registrado correctamente.");
                    TxtUsuario.Clear();
                    TxtContraseña.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre de usuario y una contraseña.");
            }
        }

        // Evento del botón "Salir" para cerrar el formulario
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
