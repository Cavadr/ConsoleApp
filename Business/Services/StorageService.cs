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
        public StorageRepository storageRepository { get; set; }
        private static int count { get; set; }
        public StorageService()
        {
            storageRepository = new StorageRepository();
        }
        
        public Storage Create(Storage storage)
        {
            try
            {
                storage.Id = count;
                Storage isExist =
                    storageRepository.Get(s => s.Name.ToLower() == storage.Name.ToLower());
                if (isExist != null)
                    return null;
                storageRepository.Create(storage);
                count++;
                return storage;

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
            return storageRepository.GetAll();
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
