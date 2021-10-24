using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace PharmacyApp.Controllers
{
    public class ProductController
    {
        private ProductService productService{ get;}
        public ProductController()
        {
            productService = new ProductService();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Select possible storage:");
            string storageName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Enter product name:");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Enter kind of product:");
            string kind = Console.ReadLine();
            Product product = new Product { Name = name, Kind = kind };
            Product newPr= productService.Create(product, storageName);
            if (newPr!=null)
            {
                Helper.ChangeTextColor(ConsoleColor.Cyan,
                    $"New product is created: {newPr.Name} - {newPr.Kind}");
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red,
                $"Could not such as storage {storageName}");
        }
        public void GetAllProductWithStorage()
        {
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Select possible storage:");
            string storageName = Console.ReadLine();
            List<Product> products = productService.GetAll(storageName);
            if (products != null)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Storage {storageName}:");
                foreach (var item in products)
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan,
                    $"{item.Id} - {item.Name} - {item.Kind}");
                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red,
                $"Could not such as storage {storageName}");
        }
    }
}
