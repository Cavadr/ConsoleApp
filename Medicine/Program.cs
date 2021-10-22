using Business.Services;
using System;
using System.Collections.Generic;
using Utilies.Helpers;

namespace Medicine
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageService stroageService = new StorageService();
            Helper.ChangeTextColor(ConsoleColor.Green, "Pharamcy");
            while (true)
            {
                Helper.ChangeTextColor(ConsoleColor.Yellow,
                    "1-Create Storage,2-Update Storage,3-Delete Storage,4-Get storage with Id," +
                    "5-Get storage with name,6-All Storage,7-Get Storage with size");
                Helper.ChangeTextColor(ConsoleColor.Blue, "Select Option Number");
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu>=1 && menu<=7)
                {
                    switch (menu)
                    {
                        case 1:
                            Helper.ChangeTextColor(ConsoleColor.Magenta, "Enter Storage Name:");
                            string name = Console.ReadLine();
                            EnterName: Helper.ChangeTextColor(ConsoleColor.Magenta, "Enter Storage medicine size:");
                            string size = Console.ReadLine();
                            int maxsize;
                            bool isTrueSize = int.TryParse(size, out maxsize);
                            if (isTrueSize)
                            {
                                string Name;
                                int Maxsize;
                                Storage storage = new Storage(Name=name,Maxsize=maxsize);
                                if (storageService.Create(storage) != null)
                                {
                                    Helper.ChangeTextColor(ConsoleColor.Cyan, $"{storage.Name} created");
                                    break;
                                }
                                else
                                {
                                    Helper.ChangeTextColor(ConsoleColor.Red, "Something is wrong!");
                                    break;
                                }
                            }
                            else
                            {
                                Helper.ChangeTextColor(ConsoleColor.Red, "Enter Correct Size");
                                goto EnterName;
                            }
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            Helper.ChangeTextColor(ConsoleColor.Magenta, "All Storages:");
                            foreach (var storage in storageService.GetAll())
                            {
                                Helper.ChangeTextColor(ConsoleColor.Blue, $"{storage.Id} - {storage.Name}");
                            }
                            break;
                        case 7:
                            break; 
                    }
                    
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please, select correct option ");
                }
            }
        }
    }

    internal class storageService
    {
        internal static object Create(Storage storage)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
