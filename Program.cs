namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineShop onlineShop = new OnlineShop();

            IProduct product1 = new Product("Product A", 10);
            IProduct product2 = new Product("Product B", 15);
            IProduct product3 = new Product("Product C", 8);




            Customer customer = new Customer("mamad Amo", "yechi@example.com");
            onlineShop.SetCustomer(customer);

            onlineShop.AddToCart(product1);
            onlineShop.AddToCart(product2);

            onlineShop.ViewCart();
            onlineShop.Checkout();
        }
        }
    }
