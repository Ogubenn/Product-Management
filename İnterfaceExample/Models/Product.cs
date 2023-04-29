using System;
namespace İnterfaceExample.Models
{
	public class Product:CommonProp
	{
        public int Id { get; set; }

        public string name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int Stock { get; set; }

        public double Price { get; set; }

        public bool IsStatus { get; set; }

        public Product()
        {
            public Product(string name, string description, int categoryId, int stock, double price);
            name = name;
            Description = Description;
            CategoryId = CategoryId;
            Stock = Stock;
            Price = Price;
        }
    }
}

