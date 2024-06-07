using CsvHelper;
using Newtonsoft.Json;
using Parcial_N_2.Clases;
using Parcial_N_2.Views;
using System;
using System.Collections;
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
    public partial class facturasForm : Form
    {
        public static Tienda tienda = new Tienda("Tu Tienda De La Esquina", "J123456789", "tutienda@gmail.com", "0274-2638595");

        public List<Factura> facturas = new List<Factura>();
        private string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Facturas.json");
        public facturasForm()
        {
            InitializeComponent();
            DatosEmpresa.Text = tienda.MostrarDatosTienda();

            if (File.Exists(ruta))
            {
               
                string json = File.ReadAllText(ruta);
                

                if (!string.IsNullOrEmpty(json))
                {
                    facturas = JsonConvert.DeserializeObject<List<Factura>>(json);

                    foreach (var item in facturas)
                    {
                        AgregarItemListView(item);
                    }
                }
                    
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            aggFactura view = new aggFactura();
            view.FormularioCerrado += (objeto) =>
            {
                var factura = objeto;

                AgregarItemListView(factura);
                GuardarDatos(factura);

            };
            view.Show();
        }

        void AgregarItemListView(Factura factura)
        {
            ListViewItem item2 = new ListViewItem(factura.IdFactura);
            item2.SubItems.Add(factura.Fecha.ToString());
            item2.SubItems.Add(factura.Cliente.Nombre);
            item2.SubItems.Add(factura.Pago);
            item2.SubItems.Add(factura.Total.ToString());
            listFacturaGeneral.Items.Add(item2);
        }
        private void GuardarDatos(Factura factura)
        {
            try
            {
                facturas.Add(factura);
                string json = JsonConvert.SerializeObject(facturas, Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el JSON");
            }

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listFacturaGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            listFacturaGeneral.Items.Clear();
            var list = facturas.OrderBy(x => x.Fecha);
            facturas = list.ToList();

            foreach (var item in facturas)
            {
                AgregarItemListView(item);
            }
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            listFacturaGeneral.Items.Clear();
            var list = facturas.OrderByDescending(x => x.Fecha);
            facturas = list.ToList();

            foreach (var item in facturas)
            {
                AgregarItemListView(item);
            }
        }
    }
}
