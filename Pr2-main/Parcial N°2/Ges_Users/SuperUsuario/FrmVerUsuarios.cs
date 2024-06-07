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


namespace Parcial_N_2.Ges_Users.SuperUsuario
{
    public partial class FrmVerUsuarios : Form
    {
        private List<Usuario> listaUsuarios; // Cambia Usuario por el nombre de tu clase de usuario

        public FrmVerUsuarios()
        {
            InitializeComponent();

            // Lee el contenido del archivo JSON de usuarios en la ubicación especificada
            string readJson = File.ReadAllText(@"C:\Users\Public\Usuarios.json");

            // Deserializa el contenido JSON en un objeto DataTable
            DataTable dataUsuarios = (DataTable)JsonConvert.DeserializeObject(readJson, typeof(DataTable));

            // Establece la fuente de datos de la tabla DataGridView (Grid_Usuarios)
            Grid_Usuarios.DataSource = dataUsuarios;
        }

        // Maneja el evento del botón "Registrar Usuario" para abrir el formulario de registro
        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistro ventRegistrarUsuario = new FrmRegistro();
            this.Hide();
            ventRegistrarUsuario.Show();
        }

        // Maneja el evento del botón "Modificar Usuarios" para abrir el formulario de modificación de usuarios
        private void button4_Click(object sender, EventArgs e)
        {
            FrmModfUsuarios ventModificarUsuarios = new FrmModfUsuarios();
            this.Hide();
            ventModificarUsuarios.Show();
        }

        // Maneja el evento del botón "Eliminar Usuario" para abrir el formulario de eliminación de usuarios
        private void button5_Click(object sender, EventArgs e)
        {
            FrmEliminarUsuario ventEliminarUsuario = new FrmEliminarUsuario();
            this.Hide();
            ventEliminarUsuario.Show();
        }

        // Maneja el evento del botón "Salir" para cerrar el formulario actual
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

// Clase para representar un usuario
public class Usuario
{
    public string Nombre { get; set; }
    public string Usuarios { get; set; }
    public string Contrasena { get; set; }
}

// Extensión para convertir una lista de objetos anónimos en un DataTable
public static class Extensions
{
    public static DataTable ToDataTable<T>(this List<T> data)
    {
        DataTable table = new DataTable();
        foreach (var prop in typeof(T).GetProperties())
        {
            table.Columns.Add(prop.Name);
        }
        foreach (var record in data)
        {
            DataRow row = table.NewRow();
            foreach (var prop in typeof(T).GetProperties())
            {
                row[prop.Name] = prop.GetValue(record, null);
            }
            table.Rows.Add(row);
        }
        return table;
    }
}

