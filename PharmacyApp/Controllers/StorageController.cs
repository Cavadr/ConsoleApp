using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace PharmacyApp.Controllers
{
    public class StorageController
    {
        public StorageService storageService { get; }
        public StorageController()
        {
            storageService = new StorageService();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Enter storage name:");
            string name = Console.ReadLine();
        EnterName: Helper.ChangeTextColor(ConsoleColor.Magenta, "Enter max medicine size:");
            string size = Console.ReadLine();
            int maxSize;
            bool isTrueSize = int.TryParse(size, out maxSize);
            if (isTrueSize)
            {
                Storage storage = new Storage { Name = name, MaxSize = maxSize };
                if (storageService.Create(storage) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, $"{storage.Name} created successfully");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something is wrong!");
                    return;
                }

            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter correct size");
                goto EnterName;
            }
        }

        public void GetAll()
        {
            Helper.ChangeTextColor(ConsoleColor.Magenta, "All Storages:");
            foreach (Storage storage in storageService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"{storage.Id} - {storage.Name}");
            }
        }
        public void Delete()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Enter Storage Id:");
            string input = Console.ReadLine();
            int storageId;
            bool isTrue = int.TryParse(input, out storageId);
            if (isTrue)
            {
                if (storageService.Delete(storageId)!=null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Yellow, "Storage is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{storageId} is not found");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Please, select correc Id");
            }
            
        }
        public void GetStorageWithSize()
        {
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Enter Storage Size:");
            string input = Console.ReadLine();
            int maxSize;
            bool isTrue = int.TryParse(input, out maxSize);
            if (isTrue)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Storages which size are {maxSize}:");
                foreach (var item in storageService.GetAll(maxSize))
                {
                    Helper.ChangeTextColor(ConsoleColor.Magenta, item.Name);
                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, "Please, select correc Id");
        }
    }
}
