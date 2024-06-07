using Parcial_N_2.Ges_Users.SuperUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_N_2
{
    public partial class FrmAfterLoginSupUser : Form
    {
        public FrmAfterLoginSupUser()
        {
            InitializeComponent();
        }

        // Evento del botón "Abrir" que abre el menú principal
        private void Btn_Open_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close(); // Cierra el formulario actual
            menu.Show();  // Muestra el formulario del menú principal
        }

        // Evento del botón "Agregar Administrador" que abre el formulario para registrar un administrador
        private void Btn_SU_AAdmin_Click(object sender, EventArgs e)
        {
            FrmRegistroAdmin frmRegistroAdmin = new FrmRegistroAdmin();
            frmRegistroAdmin.Show();  // Muestra el formulario de registro de administradores
        }

        // Evento del botón "Agregar Usuario" que abre el formulario para registrar un usuario
        private void Btn_SU_AUser_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.Show();  // Muestra el formulario de registro de usuarios
        }

        // Evento del botón "Modificar Usuario" que abre el formulario para modificar usuarios
        private void Btn_SU_MUser_Click(object sender, EventArgs e)
        {
            FrmModfUsuarios frmModfUsuarios = new FrmModfUsuarios();
            frmModfUsuarios.Show();  // Muestra el formulario de modificación de usuarios
        }

        // Evento del botón "Buscar Usuarios" que abre el formulario para ver la lista de usuarios
        private void Btn_Usuario_BL_Click(object sender, EventArgs e)
        {
            FrmClientes verClientes = new FrmClientes();
            verClientes.Show();  // Muestra el formulario de visualización de usuarios
        }

        // Evento del botón "Ver Inventario" que abre el formulario para ver el inventario de productos
        private void Btn_SU_Inv_Click(object sender, EventArgs e)
        {
            FrmProductos verProductos = new FrmProductos();
            verProductos.Show();  // Muestra el formulario de visualización del inventario de productos
        }

        // Evento del botón "Ver Administradores" que abre el formulario para ver la lista de administradores
        private void Btn_SU_VAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin verVentanaAdmins = new FrmAdmin();
            verVentanaAdmins.Show();  // Muestra el formulario de visualización de administradores
        }

        // Evento del botón "Modificar Administrador" que abre el formulario para modificar administradores
        private void Btn_SU_MAdmin_Click(object sender, EventArgs e)
        {
            FrmModifAdmin verModificarAdmin = new FrmModifAdmin();
            verModificarAdmin.Show();  // Muestra el formulario de modificación de administradores
        }

        // Evento del botón "Eliminar Administrador" que abre el formulario para eliminar administradores
        private void Btn_SU_EAdmin_Click(object sender, EventArgs e)
        {
            FrmEliminarAdmin verEliminarAdmin = new FrmEliminarAdmin();
            verEliminarAdmin.Show();  // Muestra el formulario de eliminación de administradores
        }

        // Evento del botón "Ver Usuarios" que abre el formulario para ver la lista de usuarios
        private void Btn_SU_VUser_Click(object sender, EventArgs e)
        {
            FrmVerUsuarios ventVerUsuarios = new FrmVerUsuarios();
            ventVerUsuarios.Show();  // Muestra el formulario de visualización de usuarios
        }

        // Evento del botón "Eliminar Usuario" que abre el formulario para eliminar usuarios
        private void Btn_SU_EUser_Click(object sender, EventArgs e)
        {
            FrmEliminarUsuario verEliminarUsuario = new FrmEliminarUsuario();
            verEliminarUsuario.Show();  // Muestra el formulario de eliminación de usuarios
        }
    }
}
