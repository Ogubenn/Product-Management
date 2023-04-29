using InterfaceExample.Models;
using InterfaceExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Proccesses
{
    internal class ProductProccess
    {
        private static ProductRepository repository;

        public ProductProccess(ProductRepository repository1)
        {
            repository = repository1;
        }

        public static void Add()
        {

            Console.WriteLine("Add Product");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Description:");
            string description = Console.ReadLine();
            Console.Write("CategoryId:");
            int categoryId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Stock:");
            int stock = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Product product = new Product(name, description, categoryId, stock, price);
            Console.WriteLine(repository.Add(product) ? "Ekleme Başarılı" : "Beklenmedik Bir Hata Oluştu");

        }
        public static void Menı()
        {
            bool status = true;
            while(status)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("------Product Procces Menu---------");
                Console.WriteLine("--------Select Procces----------");
                Console.WriteLine("Add Product (1)");
                Console.WriteLine("Detail Product (1)");
                Console.WriteLine("Delete Product (2)");
                Console.WriteLine("Update Product (3)");
                Console.WriteLine("Product List (4)");
                Console.WriteLine("Up Menu (5)");
                Console.WriteLine("Select Proccess (6)");
                char selected = Convert.ToChar(Console.ReadLine().Substring(0, 1));

            }
        }

    }
}
