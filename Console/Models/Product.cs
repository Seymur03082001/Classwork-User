using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Models
{
    internal class Product
    {
        private string _name;
        private double _price;

        
        public string Name
        {
            get => _name;
            set { _name = value; }
        }

        
        public double Price
        {
            get => _price;
            set { _price = value; }
        }

    }
}
