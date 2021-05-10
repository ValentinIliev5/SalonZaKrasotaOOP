using System;
using System.Collections.Generic;
using System.Text;

namespace KrasotaSalon
{
    public class ColorHair : ServiceProduct
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public override string ToString()
        {
            return $"Hair colored in {this.color}, price: {this.Price} ";
        }


        public ColorHair(string name, decimal price, string brand , string color)
        {
            Name = name;
            Price = price;
            Brand = brand;
            Color = color;
        }
    }

    public class NightCream : ServiceProduct
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public override string ToString()
        {
            return $"Night creaned with brand:{this.Brand}, price: {this.Price} ";
        }


        public NightCream(string name, decimal price, string brand)
        {
            Name = name;
            Price = price;
            Brand = brand;
        }

    }

    public class HairCut : ServiceProduct
    {
        private string style;

        public string Style
        {
            get { return style; }
            set { style = value; }
        }

        public override string ToString()
        {
            return $"Done haircut, style:{this.Style}, price: {this.Price} ";
        }


        public HairCut(string name, decimal price, string style)
        {
            Name = name;
            Price = price;
            Style = style;
        }
    }
}
