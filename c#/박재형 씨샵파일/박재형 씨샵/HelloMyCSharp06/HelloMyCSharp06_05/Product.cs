using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp06_05
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product()
        {
            
        }
        public Product(string Name)
        {
            this.Name = Name;
        }
        public Product(int price)
        {
            this.Price = price;
        }
        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
