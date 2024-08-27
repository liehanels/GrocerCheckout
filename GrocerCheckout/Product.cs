using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocerCheckout
{
    internal class Product
    {
        private string Name;
        private double Price;
        private int Qty;

        public Product (string name, double price, int qty)
        {
            this.Name = name;
            this.Price = price;
            this.Qty = qty;
        }
        public string getName() { return this.Name; }
        public double getPrice() { return this.Price; }
        public int getQty() { return this.Qty; }
        public double getTotal() {  return this.Price * this.Qty; }
    }
}
