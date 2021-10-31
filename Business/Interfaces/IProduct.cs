using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    interface IProduct
    {
        Product Create(Product product, string storageName);
        Product Update(Product product, string storageName);
        Product Delete(int Id);
        Product Get(int Id);
        Product Get(string Name);
        List<Product> GetAll();
        List<Product> GetAll(string storageName);
    }
}
