using System;
using System.Collections.Generic;
using System.Text;

namespace KrasotaSalon
{
    public class ServiceProduct
    {
        private string name;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
