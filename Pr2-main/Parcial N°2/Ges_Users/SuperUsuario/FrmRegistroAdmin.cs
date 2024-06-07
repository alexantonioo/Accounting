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
    public partial class FrmRegistroAdmin : Form
    {
        // Declaración de variables miembro
        private List<Usuarios> listaUsuarios; // Lista de administradores
        private string rutaArchivoAdminJson = "C:\\Users\\Public\\Admin.json"; // Ruta del archivo JSON

        public FrmRegistroAdmin()
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

        // Maneja el evento del botón "Registrar" para agregar un nuevo administrador
        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = TxtNombre.Text;
            string nuevoUsuario = TxtUsuario.Text;
            string nuevaContrasena = TxtContraseña.Text;

            if (!string.IsNullOrEmpty(nuevoUsuario) && !string.IsNullOrEmpty(nuevaContrasena))
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

        // Maneja el evento del botón "Limpiar" para borrar los campos de entrada
        private void button1_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtNombre.Clear();
            TxtContraseña.Clear();
        }

        // Maneja el evento del botón "Salir" para cerrar el formulario actual
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clase interna que representa un administrador con propiedades Nombre, Usuario y Contrasena
        public class Usuarios
        {
            public string Nombre { get; set; }
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }
    }
}
