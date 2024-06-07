using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_N_2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        /*Usuarios, Superusuario, Admininstrador*/

        /*TDA Usuarios         
         * 
         * Atributos:
         * Cadena de caracteres Nombre;
         * cadena de caracteres Nombre_Usuario;
         * cadena de caracteres Contraseña; --> no menor a ocho digitos
         
         *Agregar usuarios
            Producto(Cadena de caracteres Nombre,Cadena de caracteres Nombre_Usuario, Cadena de caracteres Contraseña);         
         
         *Funcionalidades del Usuario:
            -Agregar, Modificar, Ver, Eliminar cualquier informacion de algun cliente.
            -Agregar, Modificar, Ver, Eliminar los productos del Inventario.
            -Agregar, Modificar, Ver, Eliminar los productos de la lista de cmpra del cliente.
         */


        /*Clase para los usuarios*/

        public class Usuarios
        {
            private string Nombre;
            private string Nombre_Usuario;
            private string Contraseña;


            //Propiedades de la clase
            public string Name { get { return Nombre; } set { Nombre = value; } }
            public string UserName { get { return Nombre_Usuario; } set { Nombre_Usuario = value; } }
            public string Password { get { return Contraseña; } set { Contraseña = value; } }


            public Usuarios()
            {
                Nombre = "";
                Nombre_Usuario = "";
                Contraseña = "";
            }

            public Usuarios(string Nombre, string Nombre_Usuario, string Contraseña)
            {
                this.Nombre = Nombre;
                this.Nombre_Usuario = Nombre_Usuario;
                this.Contraseña = Contraseña;
            }

            //Constructor de la clase

            public void MostrarUsuario()
            {
                Console.WriteLine($"Nombre: {Nombre}, Nombre de Usuario: {Nombre_Usuario}");
            }

        }


        /*TDA Administrador      
         
         * Atributos:
         * Cadena de caracteres Nombre;
         * cadena de caracteres Nombre_Usuario;
         * cadena de caracteres Contraseña; --> no menor a doce digitos
         
         *Agregar usuarios
            Producto(Cadena de caracteres Nombre,Cadena de caracteres Nombre_Usuario,
                Cadena de caracteres Contraseña);  --> agregado un administrador ya no se podran agregar mas       
         
         *Funcionalidades del Administrador:
            -Agregar, Modificar, Ver, Eliminar cualquier informacion de algun cliente.
            -Agregar, Modificar, Ver, Eliminar los productos del Inventario.
            -Agregar, Modificar, Ver, Eliminar cualquier informacion de algun usuario normal.

         */

        public class Administrador
        {
            private string Nombre;
            private string Nombre_Usuario;
            private string Contraseña;


            //Propiedades de la clase
            public string Name { get { return Nombre; } set { Nombre = value; } }
            public string UserName { get { return Nombre_Usuario; } set { Nombre_Usuario = value; } }
            public string Password { get { return Contraseña; } set { Contraseña = value; } }


            public Administrador()
            {
                Nombre = "";
                Nombre_Usuario = "";
                Contraseña = "";
            }

            public Administrador(string Nombre, string Nombre_Usuario, string Contraseña)
            {
                this.Nombre = Nombre;
                this.Nombre_Usuario = Nombre_Usuario;
                this.Contraseña = Contraseña;
            }

            //Constructor de la clase

            public void MostrarAdministrador()
            {
                Console.WriteLine($"Nombre: {Nombre}, Nombre de Usuario: {Nombre_Usuario}");
            }

        }

        /*TDA SuperUsuario      
         
         * Atributos:
         * Cadena de caracteres Nombre;
         * cadena de caracteres Nombre_Usuario;
         * cadena de caracteres Contraseña; --> no menor a catorce digitos
         
         *Agregar usuarios
            Producto(Cadena de caracteres Nombre,Cadena de caracteres Nombre_Usuario,
                Cadena de caracteres Contraseña);  --> agregado un superusuario ya no se podran agregar mas       
         
         *Funcionalidades del Administrador:
            -Ver cualquier informacion de algun cliente.
            -Ver los productos del Inventario.
            -Agregar, Modificar, Ver, Eliminar cualquier informacion de algun usuario normal.
            -Agregar, Modificar, Ver, Eliminar cualquier informacion del Administrador.
            -Modificar el codigo del programa

         */

        public class SuperUsuario
        {
            private string Nombre;
            private string Nombre_Usuario;
            private string Contraseña;


            //Propiedades de la clase
            public string Name { get { return Nombre; } set { Nombre = value; } }
            public string UserName { get { return Nombre_Usuario; } set { Nombre_Usuario = value; } }
            public string Password { get { return Contraseña; } set { Contraseña = value; } }


            public SuperUsuario()
            {
                Nombre = "";
                Nombre_Usuario = "";
                Contraseña = "";
            }

            public SuperUsuario(string Nombre, string Nombre_Usuario, string Contraseña)
            {
                this.Nombre = Nombre;
                this.Nombre_Usuario = Nombre_Usuario;
                this.Contraseña = Contraseña;
            }

            //Constructor de la clase

            public void MostrarSuperUsuario()
            {
                Console.WriteLine($"Nombre: {Nombre}, Nombre de Usuario: {Nombre_Usuario}");
            }

        }



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
