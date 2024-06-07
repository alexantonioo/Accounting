using Newtonsoft.Json;
using Parcial_N_2.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Parcial_N_2.Views
{
    public partial class BuscarProducto : Form
    {
        public Product ProductoSelected { get; set; }
        public event Action<Product> FormularioCerrado;
        private string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Productos.json");
        //  Lista de productos principal
        public List<Product> productos = new List<Product>();
        public BuscarProducto()
        {
            InitializeComponent();

            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                productos = JsonConvert.DeserializeObject<List<Product>>(json);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {

            if (ProductoSelected != null && !string.IsNullOrEmpty(this.nudCantidad.Text))
            {

                long outData = 0;
                if  (long.TryParse(nudCantidad.Text, out outData))
                {
                    if (int.Parse(nudCantidad.Text) <= ProductoSelected.Stock && int.Parse(nudCantidad.Text) > 0) 
                    {
                        ProductoSelected.Stock = int.Parse(nudCantidad.Text);
                        FormularioCerrado?.Invoke(this.ProductoSelected);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad valida");
                    }
                }
                else
                {
                    MessageBox.Show("Formato incorrecto");
                }

            }
            else
            {
                MessageBox.Show("Verifique los campos vacios (codigo/nombre y cantidad) y seleccione un producto");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNombrePro.Text))
            {
                listViewBuscarPro.Items.Clear();
                listViewBuscarPro.Refresh();
                return;
            }

            listViewBuscarPro.Items.Clear();
            listViewBuscarPro.Refresh();
            var list=productos.Where(item=>(item.Name.ToLower().Contains(this.textNombrePro.Text)));

            foreach(var item in list)
            {
                ListViewItem item2 = new ListViewItem(item.ID);
                item2.SubItems.Add(item.Stock.ToString());
                item2.SubItems.Add(item.Name);
                item2.SubItems.Add(item.Price.ToString());
                
                this.listViewBuscarPro.Items.Add(item2);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBuscarPro.SelectedItems.Count > 0)
            {
                var item = listViewBuscarPro.SelectedItems[0];

                Product pro = new Product
                {
                    ID = listViewBuscarPro.SelectedItems[0].SubItems[0].Text,
                    Stock = int.Parse(listViewBuscarPro.SelectedItems[0].SubItems[1].Text),
                    Name= listViewBuscarPro.SelectedItems[0].SubItems[2].Text,
                    Price = double.Parse(listViewBuscarPro.SelectedItems[0].SubItems[3].Text),

                };

                ProductoSelected = pro;
            }
            else
            {
                ProductoSelected = null;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textCodigo.Text))
            {
                listViewBuscarPro.Items.Clear();
                listViewBuscarPro.Refresh();
                return;
            }

            listViewBuscarPro.Items.Clear();
            listViewBuscarPro.Refresh();
            var list = productos.Where(item => (item.ID.ToLower().Contains(this.textCodigo.Text)));

            foreach (var item in list)
            {
                ListViewItem item2 = new ListViewItem(item.ID);
                item2.SubItems.Add(item.Stock.ToString());
                item2.SubItems.Add(item.Name);
                item2.SubItems.Add(item.Price.ToString());

                this.listViewBuscarPro.Items.Add(item2);
            }
        }

        private void bttLimpiar_Click(object sender, EventArgs e) 
        {
            textNombrePro.Text = "";
            textCodigo.Text = "";
            nudCantidad.Text = "0";
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
 