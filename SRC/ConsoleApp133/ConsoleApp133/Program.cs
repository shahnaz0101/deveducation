using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp133
{    
    public class Program
    {
        static void Main(string[]args)

        {           
            
            Product products = new Product();
            products.ProName = "Phone";
            products.ProPrice = 800;
            products.DateofPro = 2023;
            
            products.ProName = "Printer";
            products.ProPrice = 1200 + '$';
            products.DateofPro = 2019;
            
            
    
        }
    }
    
    public class Product
    {
        public string ProName { get; set; }
        public int ProPrice { get; set; }
        public int DateofPro { get; set; }
    }
    public class Store
    {
        public Product[] Products { get; set; }
    }
}