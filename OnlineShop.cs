using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IShoppingCart
    {
        void AddToCart(IProduct product);
        void ViewCart();
        void Checkout();
    }
    public class OnlineShop : IShoppingCart
{
    private List<IProduct> cart;
    private ICustomer customer;

    public OnlineShop()
    {
        cart = new List<IProduct>();
    }

    public void SetCustomer(ICustomer customer)
    {
        this.customer = customer;
    }

    public void AddToCart(IProduct product)
    {
        cart.Add(product);
        Console.WriteLine($"{product.Name} added to cart.");
    }

    public void ViewCart()
    {
        if (customer != null)
        {
            Console.WriteLine($"Cart contents for {customer.Name}:");
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine(cart[i].GetInfo());
            }
        }
        else
        {
            Console.WriteLine("No customer information available.");
        }
    }

    public void Checkout()
    {
        if (customer != null)
        {
            Console.WriteLine($"Checkout for {customer.Name}:");
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine(cart[i].GetInfo());
            }
            Console.WriteLine("Payment successful. Thank you for your purchase!");
        }
        else
        {
            Console.WriteLine("No customer information available.");
        }
    }
}




}
