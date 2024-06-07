using Parcial_N_2.Clases;
using Parcial_N_2.Datos;
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
    public partial class FrmClientes : Form
    {
       
        public static Tienda tienda = new Tienda("Tu Tienda De La Esquina", "J123456789", "tutienda@gmail.com", "0274-2638595");
        public FrmClientes()
        {
            InitializeComponent();
            DatosEmpresa.Text = tienda.MostrarDatosTienda();
            ClientesRepositorio.IniciarRepositorio();
            VisualizarClientes();
        }

        private void VisualizarClientes()
        {
            dataGridView1.Rows.Clear();
            foreach(Clientes clientes in ClientesRepositorio.clientes)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = clientes.Cedula.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = clientes.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = clientes.Apellido.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = clientes.Telefono.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = clientes.Correo.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = clientes.Pais.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = clientes.Estado.ToString();
                dataGridView1.Rows[rowIndex].Cells[7].Value = clientes.Ciudad.ToString();
            }

        }

        
        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVentanaCliente ventanaAggClientes = new FrmVentanaCliente();
            DialogResult dialogResult = ventanaAggClientes.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                ClientesRepositorio.AñadirClientes(ventanaAggClientes.Client);
                VisualizarClientes();
            
            }

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Eliminar la fila seleccionada

                string cedulaClienteEliminar = dataGridView1.Rows[e.RowIndex].Cells["ColumaCedula"].Value.ToString();

                ClientesRepositorio.ElminiarCliente(cedulaClienteEliminar);
                VisualizarClientes();
            }

            if (e.ColumnIndex == dataGridView1.Columns["Modificar"].Index && e.RowIndex >= 0)
            {



                string cedulaClienteModificar = dataGridView1.Rows[e.RowIndex].Cells["ColumaCedula"].Value.ToString();
                string nombreClienteModificar = dataGridView1.Rows[e.RowIndex].Cells["ColumnaNombre"].Value.ToString();
                string apellidoClienteModificar = dataGridView1.Rows[e.RowIndex].Cells["ColumnaApellido"].Value.ToString();
                string telefonoClienteModificar = dataGridView1.Rows[e.RowIndex].Cells["ColumnaTelefono"].Value.ToString();
                string correoClienteModificar = dataGridView1.Rows[e.RowIndex].Cells["ColumnaCorreo"].Value.ToString();
                string paisClienteModificar = dataGridView1.Rows[e.RowIndex].Cells["ColumnaPais"].Value.ToString();
                string estadoClienteModificar = dataGridView1.Rows[e.RowIndex].Cells["ColumnaEstado"].Value.ToString();
                string ciudadClienteModificar = dataGridView1.Rows[e.RowIndex].Cells["ColumnaCiudad"].Value.ToString();


                DialogResult result = MessageBox.Show($" ID:  {cedulaClienteModificar}\n Nombre:  {nombreClienteModificar}\n Apellido:  {apellidoClienteModificar}\n Telefono:  {telefonoClienteModificar}\n Correo:  {correoClienteModificar}\n\n" +
                     $" ¿Estás seguro de modificar el cliente?", "Confirmar modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                { 


                    Clientes clienteModificar = new Clientes(cedulaClienteModificar, nombreClienteModificar, apellidoClienteModificar, telefonoClienteModificar, correoClienteModificar, paisClienteModificar, estadoClienteModificar, ciudadClienteModificar);
                FrmVentanaCliente clienteMod = new FrmVentanaCliente(clienteModificar);
                DialogResult dialogResult = clienteMod.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    ClientesRepositorio.ModificarCliente(cedulaClienteModificar, clienteMod.Client);
                    VisualizarClientes();
                }

                }
            }



            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorSeleccionado = comboBox1.SelectedIndex;
            IEnumerable<Clientes> clientesOrdenados;

            switch (valorSeleccionado)
            {

                case 0:
                    clientesOrdenados = from Clientes in ClientesRepositorio.clientes orderby Clientes.Nombre select Clientes;
                    ClientesRepositorio.clientes = clientesOrdenados.ToList();
                    VisualizarClientes();
                    break;
                case 1:
                    clientesOrdenados = from Clientes in ClientesRepositorio.clientes orderby Clientes.Apellido select Clientes;
                    ClientesRepositorio.clientes = clientesOrdenados.ToList();
                    VisualizarClientes();
                    break;
                case 2:
                    clientesOrdenados = from Clientes in ClientesRepositorio.clientes orderby Clientes.Cedula select Clientes;
                    ClientesRepositorio.clientes = clientesOrdenados.ToList();
                    VisualizarClientes();
                    break;
            }

        }
    }
}

