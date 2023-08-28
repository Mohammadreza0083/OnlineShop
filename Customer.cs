using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICustomer
    {
        string Name { get; }
        string Email { get; }
        string GetInfo();
    }
    public class Customer : ICustomer
    {
        public string Name { get; }
        public string Email { get; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string GetInfo()
        {
            return $"{Name} - {Email}";
        }
    }

}
