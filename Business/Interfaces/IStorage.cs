using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IStorage
    {
        Storage Create(Storage storage);
        Storage Update(int Id, Storage storage);
        Storage Delete(int Id);
        Storage Get(int Id);
        Storage Get(string Name);
        List<Storage> GetAll();
        List<Storage> GetAll(int MaxSize);

    }
}
