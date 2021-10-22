using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class StorageService : IStorage
    {
        public StorageRepository StorageRepository { get; set; }
        private static int count { get; set; }
        
        public Storage Create(Storage storage)
        {
            try
            {
                storage.Id = count;

            }
            catch (Exception)
            {

                return null;
            }
        }

        public Storage Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Storage Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Storage Get(string Name)
        {
            throw new NotImplementedException();
        }

        public List<Storage> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Storage> GetAll(int MaxSize)
        {
            throw new NotImplementedException();
        }

        public Storage Update(int Id, Storage storage)
        {
            throw new NotImplementedException();
        }
    }
}
