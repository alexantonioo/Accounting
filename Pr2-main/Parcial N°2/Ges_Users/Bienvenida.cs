using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Parcial_N_2.Ges_Users.Admin;
using Parcial_N_2.Ges_Users.SuperUsuario;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Parcial_N_2
{
    public partial class Bienvenida : Form
    {
        // Cambiar la declaración de Usuarios a una lista
        private static readonly List<User> Usuarios = new List<User>
        {
            new User { Nombre = "Alex", Usuario = "Usuario", Contrasena = "12345678" },
            new User { Nombre = "Jose", Usuario = "Administrador", Contrasena = "PR212345678" },
            new User { Nombre = "Luisa", Usuario = "SuperUsuario", Contrasena = "Holamundo12345678" }
        };

        public Bienvenida()
        {
            InitializeComponent();
        }

        // Maneja el evento del botón "Salir" para cerrar la aplicación
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para crear usuarios, administradores y superusuarios en memoria
        private void CrearUsuarios()
        {
            // Ejemplo de cómo crear un nuevo usuario (puedes usar esta función para crear usuarios, administradores y superusuarios)
            User nuevoUsuario = new User { Nombre = "NuevoUsuario", Usuario = "Usuario", Contrasena = "NuevaContrasena" };
            Usuarios.Add(nuevoUsuario);
        }

        // Maneja el evento del botón "Iniciar Sesión como Usuario"
        private void button3_Click(object sender, EventArgs e)
        {
            FrmLoginUsuario ventLoginUser = new FrmLoginUsuario();

            // Muestra el formulario de inicio de sesión de usuarios
            this.Hide();
            ventLoginUser.Show();
        }

        // Maneja el evento del botón "Iniciar Sesión como Administrador"
        private void Btn_LoginAdmin_Click(object sender, EventArgs e)
        {
            FrmLoginAdmin ventLoginAdmin = new FrmLoginAdmin();


            // Muestra el formulario de inicio de sesión de usuarios
            this.Hide();
            ventLoginAdmin.Show();
        }

        // Maneja el evento del botón "Iniciar Sesión como SuperUsuario"
        private void Btn_LoginSuser_Click(object sender, EventArgs e)
        {
            FrLoginSuperUsers ventLoginSuperUser = new FrLoginSuperUsers();

            // Muestra el formulario de inicio de sesión de usuarios
            this.Hide();
            ventLoginSuperUser.Show();
        }

        public class User
        {
            public string Nombre { get; set; }
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }
    }
}
