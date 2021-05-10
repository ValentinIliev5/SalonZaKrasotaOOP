using System;
using System.Collections.Generic;
using System.Text;

namespace KrasotaSalon
{
    public class Visit
    {
        public Customer customer;
        public List<ServiceProduct> ServicesAndProducts = new List<ServiceProduct>();

        public void AddServiceProduct(ServiceProduct SP)
        {
            this.ServicesAndProducts.Add(SP);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in ServicesAndProducts)
            {
                total += item.Price;
            }
            total = total - total * customer.Membership.GetDiscount();
            return total;

        }

        public void PrintInvoice()
        {
            foreach (var item in ServicesAndProducts)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("________________");
            }
        }


        public Visit(Customer customer)
        {
            this.customer = customer;
        }
    }
}
