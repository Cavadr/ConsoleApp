using Business.Services;
using Entities.Models;
using PharmacyApp.Controllers;
using System;
using Utilies.Helpers;

namespace PharmacyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageController storageController = new StorageController();
            ProductController productController = new ProductController();
            Helper.ChangeTextColor(ConsoleColor.Green, "Pharmacy");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu>=1 && menu<=9)
                {
                    switch (menu)
                    {
                        case(int) Helper.Menu.CreateStorage:
                            storageController.Create();
                            break;
                        case (int)Helper.Menu.UploadStorage:
                            break;
                        case (int)Helper.Menu.DeleteStorage:
                            storageController.Delete();
                            break;
                        case (int)Helper.Menu.GetStorageWithId:
                            break;
                        case (int)Helper.Menu.GetStoragewithName: 
                            break;
                        case (int)Helper.Menu.GetAllStorages:
                            storageController.GetAll();
                            break;
                        case (int)Helper.Menu.GetStoragesWithSize:
                            storageController.GetStorageWithSize();
                            break;
                        case (int)Helper.Menu.CreateProduct:
                            storageController.GetAll();
                            productController.Create();
                            break;
                        case (int)Helper.Menu.GetAllProductWithStorage:
                            storageController.GetAll();
                            productController.GetAllProductWithStorage();
                            break;
                    }
                }
                else if (menu == 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "You are welcome <3");
                    break;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please, Select correct option");
                }
            }
        }
        static void ShowMenu()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow,
                    "1-Create Storage, 2-Update Storage, 3-Delete Storage, 4-Get Storage with Id," +
                    " 5-Get Storage with Name, 6-All Storages, 7-Get Storage with size," +
                    " 8-Create Product, 9-Get products in storage, 0-Exit,");
            Helper.ChangeTextColor(ConsoleColor.Blue, "Please, select option number:");
        }
    }
}
