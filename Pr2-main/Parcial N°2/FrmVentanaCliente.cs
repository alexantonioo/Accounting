using Parcial_N_2.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_N_2
{
    public partial class FrmVentanaCliente : Form
    {

        public Clientes Client {  get; private set; }
        public FrmVentanaCliente()
        {
            InitializeComponent();
        }

        public FrmVentanaCliente(Clientes clientes)
        {
            InitializeComponent();
            tbxCedula.Text = clientes.Cedula;
            tbxNombre.Text  = clientes.Nombre;
            tbxApellido.Text = clientes.Apellido;
            tbxPais.Text = clientes.Ciudad;
            tbxEstado.Text = clientes.Telefono; 
            tbxCiudad.Text = clientes.Correo;
            tbxTelefono.Text = clientes.Pais;
            tbxCorreo.Text = clientes.Estado;
             
        }

        private void btn_regreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool clienteValidado = ValidarCliente(out string errorMsg);

            if (clienteValidado)
            {
                Client = new Clientes(tbxCedula.Text, tbxNombre.Text, tbxApellido.Text, tbxPais.Text, tbxEstado.Text, tbxCiudad.Text, tbxTelefono.Text, tbxCorreo.Text);
                this.DialogResult = DialogResult.OK;
            }
           else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private bool ValidarCliente(out string errorMsg)
        {
            errorMsg = string.Empty;

            if (string.IsNullOrEmpty(tbxNombre.Text)) 
            { 
                errorMsg += "El nombre del cliente no puede estar vacio" + Environment.NewLine;
            }

            if (!Regex.IsMatch(tbxNombre.Text, @"^[a-zA-Z]+$"))// Valida que el nombre solo contenga letras
            {
                errorMsg += "El nombre del cliente debe contener solo letras" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(tbxApellido.Text))
            {
                errorMsg += "El apellido del cliente no puede estar vacio" + Environment.NewLine;
            }

            if (!Regex.IsMatch(tbxApellido.Text, @"^[a-zA-Z]+$"))// Valida que el apellido solo contenga letras
            {
                errorMsg += "El apellido del cliente debe contener solo letras" + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(tbxCedula.Text))
            {
                errorMsg += "La identificacion del cliente no puede estar vacio" + Environment.NewLine;
            }

            if (!Regex.IsMatch(tbxCedula.Text, @"^[VJE]-\d+$", RegexOptions.IgnoreCase))// Valida que la cédula tenga un formato válido (V, J o E seguido de números)
            {
                errorMsg += "La identificación debe tener un formato válido (V, J o E seguido de números) Ejemplo válido: V-12345678.";
                
            }


            if (string.IsNullOrEmpty(tbxPais.Text))
            {
                errorMsg += "El pais del cliente no puede estar vacio" + Environment.NewLine;
            }

            if (!Regex.IsMatch(tbxPais.Text, @"^[a-zA-Z]+$"))// Valida que el pais solo contenga letras
            {
                errorMsg += "El pais debe contener solo letras." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(tbxEstado.Text))
            {
                errorMsg += "El estado del cliente no puede estar vacio" + Environment.NewLine;
            }

            if (!Regex.IsMatch(tbxEstado.Text, @"^[a-zA-Z]+$"))// Valida que el estado solo contenga letras
            {
                errorMsg += "El estado debe contener solo letras." + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(tbxCiudad.Text))
            {
                errorMsg += "la ciudad del cliente no puede estar vacio" + Environment.NewLine;

            }

            if (!Regex.IsMatch(tbxCiudad.Text, @"^[a-zA-Z]+$"))// Valida que la ciudad solo contenga letras
            {
                errorMsg += "El estado debe contener solo letras." + Environment.NewLine;
            }


            if (string.IsNullOrEmpty(tbxTelefono.Text))
            {
                errorMsg += "El telefono del cliente no puede estar vacio" + Environment.NewLine;
            }

            if (!IsValidPhoneNumber(tbxTelefono.Text))// Valida que el teléfono tenga un formato válido
            {
                errorMsg += "El telefono debe tener un formato valido. Ejemplo: 0416-1234567 ó 0416 1234567 ó 04161234567\"";
                
            }

            if (string.IsNullOrEmpty(tbxCorreo.Text))
            {
                errorMsg += "El correo del cliente no puede estar vacio" + Environment.NewLine;
            }

            try
            {
                new MailAddress(tbxCorreo.Text);    
            }catch 
            {
                errorMsg += "El Email debe tener un formato correcto" + Environment.NewLine;
            }

            return errorMsg == String.Empty;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"^\+[0-9]{1,3}[\ -]?\(?[0-9]{1,3}\)?[\ -]?[0-9]{7,8}$") || Regex.IsMatch(phoneNumber, @"^0[0-9]{3}[\ -]?[0-9]{3}[\ -]?[0-9]{4}$") || Regex.IsMatch(phoneNumber, @"^\([0-9]{4}\)[\ ]?[0-9]{3}[\ -]?[0-9]{4}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
