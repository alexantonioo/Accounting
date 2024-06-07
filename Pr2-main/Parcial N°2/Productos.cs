using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_N_2
{

    // Clase de productos provicional para probar importacion y exportacion 
    public class Product
    {
        // atributos
        private string _name;
        private double _price;
        private double _totalPrice;
        private int _stock;
        private string _description;
        private string _id;

        // propiedades
        public string Name { get { return _name; } set { _name = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public double TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }

        public string Description { get { return _description; } set { _description = value; } }
        public string ID { get { return _id; } set { _id = value; } }


        public Product()
        {
            _name = string.Empty;
            _price = 0;
            _stock = 0;
            _description = string.Empty;
            _id = string.Empty;
            _totalPrice = 0;
        }

        public Product(string name, double price, int stock, string description, string id)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Description = description;
            _id = id;
        }
 

    }
}