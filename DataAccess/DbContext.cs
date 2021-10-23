using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class DbContext
    {
        public static List<Product> Products { get;  }
        public static List<Storage> Storages { get; }
         static  DbContext()
        {
            Products = new List<Product>();
            Storages = new List<Storage>();
        }
    }
}
