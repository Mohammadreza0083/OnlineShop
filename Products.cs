using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IProduct
    {
        string Name { get;}
        int Quantity { get; set; }
        string GetInfo();
    }
    public class Product : IProduct
    {
        public string Name { get; }
        public int Quantity { get; set; }

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string GetInfo()
        {
            return $"{Name} - {Quantity}";
        }
    }


}
