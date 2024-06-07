using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using Parcial_N_2.Clases;


namespace Parcial_N_2
{
    public partial class FrmProductos : Form
    {
        // Instancia de tienda para mostrar los datos de la tienda
        public static Tienda tienda = new Tienda("Tu Tienda De La Esquina", "J123456789", "tutienda@gmail.com", "0274-2638595");

        // ruta donde se guardan los productos 
        private string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Productos.json");


        //  Lista de productos principal
        public List<Product> _productos = new List<Product>();
        // lista de productos que quiero importar
        private List<Product> productosAImportar = new List<Product>();

        //Lista Filtrada 
        private IEnumerable<Producto> listafiltrada;

        public FrmProductos()
        {
            InitializeComponent();

            // muestro los datos de la empresa 
            DatosEmpresa.Text = tienda.MostrarDatosTienda();

            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                _productos = JsonConvert.DeserializeObject<List<Product>>(json);
            }

            ActualizarDataGridView();
        }

        // Actualizar la tabla 

        public void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear(); // Limpia todas las filas existentes en el DataGridView.

            foreach (Product producto in _productos)
            {
                // Agregar una fila al DataGridView con los datos del producto.
                dataGridView1.Rows.Add(producto.ID, producto.Name, producto.Description, producto.Price, producto.Stock);
            }
            GuardarDatos();
            ActualizarProductosBajoStock();
        }

        // guardar datos 

        private void GuardarDatos()
        {
            try
            {
                string json = JsonConvert.SerializeObject(_productos, Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el JSON");
            }

        }

        // Esta funcion se ejecuta al darle click a Agregar
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarProductos ventanaAggProductos = new FrmAgregarProductos(this);
            ventanaAggProductos.Show();


        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // EXPORTAR DATOS DE LA LISTA DE PRODUCTOS A UN ARCHIVO CSV
        private void button2_Click(object sender, EventArgs e)
        {
            // se abre ventana de dialogo para guardar el archivo 
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "Archivo CSV (*.csv)|*.csv";
            savefiledialog.FileName = "Productos.csv";
            savefiledialog.Title = "Exportar datos de productos a csv";


            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    using (StreamWriter writer = new StreamWriter(savefiledialog.FileName))
                    {
                        writer.WriteLine("Name;Price;Stock;Description");

                        foreach (var producto in _productos)
                        {
                            writer.WriteLine($"{producto.Name};{producto.Price};{producto.Stock};{producto.Description}");
                        }
                        MessageBox.Show("Archivo exportado correctamente");
                    }

                }

                catch
                {
                    MessageBox.Show($"Eror.\n\n Intente de nuevo");
                }
            }
        }

        // IMPORTAR DATOS DE PRODUCTOS DESDE ARCHIVO CSV
        private void button3_Click(object sender, EventArgs e)
        {
            // instale csvhelper es una biblioteca para leer y escribir archivos csv


            OpenFileDialog openfiledialog = new OpenFileDialog();
            // filter es una propuedad de openfiledialog permite especificar los tipos de archivos que se muestran
            openfiledialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            openfiledialog.Title = "Importar datos desde archivo";

            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                string direccionArchivo = openfiledialog.FileName;

                if (Path.GetExtension(direccionArchivo) == ".csv")
                {
                    try
                    {
                        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                        {

                            HasHeaderRecord = true,
                        };

                        using (var reader = new StreamReader(direccionArchivo))
                        using (var csv = new CsvReader(reader, csvConfig))
                        {
                            var records = new List<Product>();
                            csv.Read();
                            csv.ReadHeader();

                            string[] headerRecord = csv.Parser.Record;


                            string headerName = headerRecord[0].ToLower().Trim();
                            string headerDescription = headerRecord[1].ToLower().Trim();
                            string headerPrice = headerRecord[2].ToLower().Trim();
                            string headerStock = headerRecord[3].ToLower().Trim();


                            if (headerName != "name" || headerPrice != "price" || headerStock != "stock" || headerDescription != "description")
                            {
                                MessageBox.Show("El archivo seleccionado no tiene el encabezado correcto.");

                            }
                            if (headerRecord.Length != 4)
                            {
                                MessageBox.Show("El archivo CSV seleccionado no tiene el numero correcto de columnas.");
                            }
                            else
                            {
                                while (csv.Read())
                                {
                                    var record = new Product()
                                    {
                                        Name = csv.GetField("Name"),
                                        Price = csv.GetField<double>("Price"),
                                        Stock = csv.GetField<int>("Stock"),
                                        Description = csv.GetField("Description"),

                                    };
                                    productosAImportar.Add(record);
                                }

                            }

                        }
                    }
                    //se lanza cuando detecta un error de seguridad
                    catch (SecurityException ex)
                    {
                        MessageBox.Show($"Eror de seguridad.\n\nError: {ex.Message}\n\n" +
                        $"Detalles:\n\n{ex.StackTrace}");
                    }
                }
                else
                {
                    MessageBox.Show("Solo se permiren archivos CSV. Seleccione un archivo CSV valido.", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            foreach (Product product in productosAImportar)
            {
                product.ID = Guid.NewGuid().ToString().Substring(0, 6);
            }

            _productos.AddRange(productosAImportar);

            productosAImportar.Clear();

            ActualizarDataGridView();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

 
        // funcion para modificar producto 
        private void ModificarProducto(string idProductoModificar, Product productoModificado)
        {


            DialogResult result = MessageBox.Show($" ID:  {idProductoModificar}\n Nombre:  {productoModificado.ID}\n Descripcion:  {productoModificado.Description}\n Precio:  {productoModificado.Price}\n Cantidad:  {productoModificado.Stock}\n\n" +
              $" ¿Desea realizar los cambios?", "Confirmar modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int poscionProducto = _productos.FindIndex(p => p.ID == idProductoModificar);
                if (poscionProducto > -1)
                {
                    _productos[poscionProducto] = productoModificado;
                }
            }

        }

        // funcion para eliminar producto 
        private void EliminarProducto(string idProductoAEliminar)
        {
            Product productoMostrar = _productos.FirstOrDefault(p => p.ID == idProductoAEliminar);

            if (productoMostrar != null)
            {
                DialogResult result = MessageBox.Show($" ID:  {productoMostrar.ID}\n Nombre:  {productoMostrar.Name}\n Descripcion:  {productoMostrar.Description}\n Precio:  {productoMostrar.Price}\n Cantidad:  {productoMostrar.Stock}\n\n" +
                $" ¿Estás seguro de eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    _productos.Remove(productoMostrar);
                    MessageBox.Show("Producto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //Eliminar y modificar
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["buttonEliminar"].Index && e.RowIndex >= 0)
            {
                // Eliminar la fila seleccionada

                string id = dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();

                EliminarProducto(id);
         
                ActualizarDataGridView();

            }

            if (e.ColumnIndex == dataGridView1.Columns["buttonModificar"].Index && e.RowIndex >= 0)
            {
                string idProductoModificar = dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                string nombreProductoModificar = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                string descripcionProductoModificar = dataGridView1.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                double precioProductoModificar = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value);
                int cantidadProductoModificar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Existencia"].Value);



                DialogResult result = MessageBox.Show($" ID:  {idProductoModificar}\n Nombre:  {nombreProductoModificar}\n Descripcion:  {descripcionProductoModificar}\n Precio:  {precioProductoModificar}\n Cantidad:  {cantidadProductoModificar}\n\n" +
                  $" ¿Estás seguro de modificar el producto?", "Confirmar modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    Product product = new Product(nombreProductoModificar, precioProductoModificar, cantidadProductoModificar, descripcionProductoModificar, idProductoModificar);
                    FrmModProductos modificarProductos = new FrmModProductos(product);

                    DialogResult dialogResult = modificarProductos.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        Product productoModificado = modificarProductos.nuevoProducto;
                        ModificarProducto(idProductoModificar, productoModificado);
                        
                        ActualizarDataGridView();
                    }

                }
            }

        }

        public void ActualizarProductosBajoStock()
        {
            //usamos linq para filtrar productos con stock menor a 5 y los almacenamos en una lista
            var productosBajoStock = _productos.Where(producto => producto.Stock < 5).ToList();

            //Inicializamos el texto con el encabezado
            label2.Text = "Productos con poco stock:\n";

            //usamos string.Join para concatenar los nombres de productos con poco stock
            //seleccionamos el nombre y el stock de cada producto y los formateamos como una cadena
            label2.Text += string.Join("\n", productosBajoStock.Select(producto => $"{producto.Name} - Stock: {producto.Stock}"));

            //si no hay productos con poco stock para borrar el texto en el label.
            if (string.IsNullOrEmpty(label2.Text))
            {
                label2.Text = "";
            }
        }


        private void DatosEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int valorSeleccionado = comboBox1.SelectedIndex;
            IEnumerable<Product> productosOrdenados;

            switch (valorSeleccionado) 
            {
            
                case 0:
                    productosOrdenados = from Product in _productos orderby Product.Name select Product;
                    _productos = productosOrdenados.ToList();
                    ActualizarDataGridView();
                    break;
                case 1:
                    productosOrdenados = from Product in _productos orderby Product.Description select Product;
                    _productos = productosOrdenados.ToList();
                    ActualizarDataGridView();
                    break;
                case 2:
                    productosOrdenados = from Product in _productos orderby Product.Stock select Product;
                    _productos = productosOrdenados.ToList();
                    ActualizarDataGridView();
                    break;
                case 3:
                    productosOrdenados = from Product in _productos orderby Product.Price select Product;
                    _productos = productosOrdenados.ToList();
                    ActualizarDataGridView();
                    break;      
            }
            
        }

        private void FrmProductos_Load_1(object sender, EventArgs e)
        {

        }
    }
}

