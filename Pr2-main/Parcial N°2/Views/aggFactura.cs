
using Parcial_N_2.Clases;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Parcial_N_2.Views
{
    public partial class aggFactura : Form
    {
        Bitmap memoryImage;

        public List<Product> productos = new List<Product>();
        public double Subtotal { get; set; } = 0;
        public double PorcentajeIva { get; set; } = 16;
        public double Iva { get; set; } = 0;
        public double Total { get; set; } = 0;

        public event Action<Factura> FormularioCerrado;

        public string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Productos.json");
        public Factura Factura { get; set; }
        public aggFactura()
        {
            InitializeComponent();
            textCedula.Enabled = false;
            cbRif.Enabled = false;
            rbIva1.Enabled = false;
            rbIva2.Enabled = false;
            rbIva2.Checked = true;

        }

        private void buttonAggProducto_Click(object sender, EventArgs e)
        {
            Product producto = new Product();

            BuscarProducto view = new BuscarProducto();            

            view.FormularioCerrado += (objeto) =>
            {
                producto = objeto;
                producto.TotalPrice = producto.Price * producto.Stock;
                //productos.Add(producto);

                ListViewItem item2 = new ListViewItem(producto.ID);
                item2.SubItems.Add(producto.Stock.ToString());
                item2.SubItems.Add(producto.Name);
                item2.SubItems.Add(producto.Price.ToString());
                item2.SubItems.Add(producto.TotalPrice.ToString());

                this.listNuevaFact.Items.Add(item2);
                productos.Add(producto);
                Subtotal += producto.TotalPrice;
                Iva = (Subtotal * PorcentajeIva) / 100;
                Total = Subtotal + Iva;

                this.labelMontoSub.Text = Subtotal.ToString();
                this.labelMontoIva.Text = Iva.ToString();
                this.labelMontoTtal.Text = Total.ToString();
                // Realizar cualquier acción necesaria con el objeto recibido
            };

            view.Show();
        }
        private void GuardarDatos(List<Product> p )
        {
            try
            {
                string json = JsonConvert.SerializeObject(p, Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el JSON");
            }

        }
        private void Imprimir(object sender, EventArgs e)
        {
            #region Validaciones
            if (productos.Count == 0)
            {
                MessageBox.Show("Agregue un producto");
                return;
            }

            if ( MetodoPago.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un metodo de pago");
                return;
            }

            if (string.IsNullOrEmpty(textCliente.Text) || string.IsNullOrEmpty(textCedula.Text) || string.IsNullOrEmpty(textTelefono.Text))
            {
                MessageBox.Show("Campos vacios");
                return;
            }
            long outData = 0;
            if (!long.TryParse(textTelefono.Text,out outData) || !long.TryParse(textCedula.Text, out outData))
            {
                MessageBox.Show("Formato de telefono o cedula incorrectos");
                return;
            }
            #endregion

            #region generar PDF
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", "Factura "+ DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", textCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", textCedula.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = (decimal)Total;
            foreach (ListViewItem row in listNuevaFact.Items)
            {
                filas += "<tr>";
                filas += "<td>" + row.SubItems[1].Text + "</td>";
                filas += "<td>" + row.SubItems[2].Text + "</td>";
                filas += "<td>" + row.SubItems[3].Text + "</td>";
                filas += "<td>" + row.SubItems[4].Text + "</td>";
                filas += "</tr>";                
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUBTOTAL", Subtotal.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@IVA", Iva.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

            #endregion

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Imagen_de_WhatsApp_2023_10_22_a_las_13_041, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 80);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

                Factura = new Factura
                {
                    Cliente = new Cliente
                    {
                        Nombre = textCliente.Text,
                        Cedula = textCedula.Text,
                        Telefono = textTelefono.Text,
                    },

                    productos = productos,
                    Total = Total,
                    Iva = Iva,
                    Subtotal = Subtotal,
                    Fecha = fechaPicker.Value,
                    IdFactura = DateTime.Now.ToString("ddMMyyyyHHmmss"),
                    Pago = MetodoPago.SelectedItem.ToString()
                };

                actualizaProductos();
                FormularioCerrado?.Invoke(this.Factura);
                MessageBox.Show("Factura generada exitosamente");
            }
            this.Close();
        }
        void actualizaProductos()
        {
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                var productosStock = JsonConvert.DeserializeObject<List<Product>>(json);
                foreach(Product product in productos)
                {
                   var p = productosStock.Where(item => item.ID == product.ID).FirstOrDefault();
                   var posicion = productosStock.IndexOf(p);
                
                    if (posicion >= 0)
                     productosStock[posicion].Stock = productosStock[posicion].Stock - product.Stock;
                    
                }
                GuardarDatos(productosStock);
            }
        }

        void imprimir_copia()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            PrintDocument pd = new PrintDocument();
            pd.Print();
        }

        private void PrintDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e) =>
               e.Graphics.DrawImage(memoryImage, 0, 0);

        private void aggFactura_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDocumento.SelectedIndex == 0)
            {
                textCedula.MaxLength = 9;
                textCedula.Enabled = true;
                cbRif.Enabled = false;
                rbIva1.Enabled = false;
                rbIva2.Enabled = true;
                rbIva2.Checked = true;
                cbRif.Text = "";
                textCedula.Text = "";
            }
            else if (cbDocumento.SelectedIndex == 1)
            {
                textCedula.MaxLength = 10;
                textCedula.Enabled = true;
                cbRif.Enabled = true;
                rbIva1.Enabled = true;
                rbIva2.Enabled = true;
                textCedula.Text = "";
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo;
            int posicion;

            if (listNuevaFact.SelectedItems.Count > 0)
            {
                var item = listNuevaFact.SelectedItems[0];
                codigo = listNuevaFact.SelectedItems[0].SubItems[0].Text;
                posicion = listNuevaFact.SelectedItems.IndexOf(item);
                var producto = productos.Where(i => i.ID == codigo).FirstOrDefault();


                DialogResult result = MessageBox.Show($" ID:  {producto.ID}\n Nombre:  {producto.Name}\n Descripcion:  {producto.Description}\n Precio:  {producto.Price}\n Cantidad:  {producto.Stock}\n\n" +
                $" ¿Estás seguro de eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    productos.Remove(producto);
                    listNuevaFact.Items.RemoveAt(posicion);
                    MessageBox.Show("Producto eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void panelNuevaFactura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {
            textTelefono.MaxLength = 11;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void labelIva_Click(object sender, EventArgs e)
        {

        }

        private void rbIva1_CheckedChanged(object sender, EventArgs e)
        {
            PorcentajeIva = 12;
            Iva = (Subtotal * PorcentajeIva) / 100;
            Total = Subtotal + Iva;
            this.labelMontoIva.Text = Iva.ToString();
            this.labelMontoTtal.Text = Total.ToString();
        }

        private void labelMontoIva_Click(object sender, EventArgs e)
        {
            
        }

        private void rbIva2_CheckedChanged(object sender, EventArgs e)
        {
            PorcentajeIva = 16;
            Iva = (Subtotal * PorcentajeIva) / 100;
            Total = Subtotal + Iva;
            this.labelMontoIva.Text = Iva.ToString();
            this.labelMontoTtal.Text = Total.ToString();
        }
    }
  
}
