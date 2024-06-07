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

namespace Parcial_N_2
{
    public partial class FrmAdmin : Form
    {
        public static Tienda tienda = new Tienda("Tu Tienda De La Esquina", "J123456789", "tutienda@gmail.com", "0274-2638595");
        public FrmAdmin()
        {
            InitializeComponent();
            DatosEmpresa.Text = tienda.MostrarDatosTienda();

            // Cargar datos de administradores desde un archivo JSON
            string readJson = File.ReadAllText(@"C:\Users\Public\Admin.json");
            DataTable dataAdmins = (DataTable)JsonConvert.DeserializeObject(readJson, typeof(DataTable));

            // Mostrar los datos de administradores en un DataGridView
            Grid_Admins.DataSource = dataAdmins;
        }

        // Evento del botón (sin nombre o descripción) - No realiza ninguna acción
        private void button1_Click(object sender, EventArgs e)
        {
            // Este botón no tiene funcionalidad en el código proporcionado.
        }

        // Evento del botón "Salir" para cerrar el formulario
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento del botón (sin nombre o descripción) - No realiza ninguna acción
        private void button4_Click(object sender, EventArgs e)
        {

        }



        // Evento del label "Dts_User" - No realiza ninguna acción
        private void Label_Dts_User_Click(object sender, EventArgs e)
        {

        }

        private void DatosEmpresa_Click(object sender, EventArgs e)
        {

        }
    }

}
