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
    public partial class FrmAfterLogin : Form
    {
        public FrmAfterLogin()
        {
            InitializeComponent();
        }

        // Evento del botón "Modificar Usuarios" para abrir el formulario de modificación de usuarios
        private void Btn_MUsers_Click(object sender, EventArgs e)
        {
            FrmModfUsuarios frmModfUsuarios = new FrmModfUsuarios();
            frmModfUsuarios.Show();
        }

        // Evento del botón "Agregar Usuarios" para abrir el formulario de registro de usuarios
        private void Btn_AUsers_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.Show();
        }

        // Evento del botón "Abrir" para volver al menú principal
        private void Btn_Open_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        // Evento del botón "Ver Usuarios" para abrir el formulario de visualización de usuarios
        private void Btn_VUsers_Click(object sender, EventArgs e)
        {
            FrmVerUsuarios ventVerUsuarios = new FrmVerUsuarios();
            ventVerUsuarios.Show();
        }

        // Evento del botón "Eliminar Usuarios" para abrir el formulario de eliminación de usuarios
        private void Btn_EUsers_Click(object sender, EventArgs e)
        {
            FrmEliminarUsuario ventEliminarUsuario = new FrmEliminarUsuario();
            ventEliminarUsuario.Show();
        }
    }
}
