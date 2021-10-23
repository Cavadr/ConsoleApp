using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class StorageRepository : IRepository<Storage>
    {
        public bool Create(Storage entity)
        {
            try
            {
                DbContext.Storages.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Storage entity)
        {
            try
            {
                DbContext.Storages.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Storage Get(Predicate<Storage> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Storages[0]
                    : DbContext.Storages.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Storage> GetAll(Predicate<Storage> filter = null)
        {
            return filter == null ? DbContext.Storages
                    : DbContext.Storages.FindAll(filter);
        }

        public bool Update(Storage entity)
        {
            try
            {
                Storage dbStorage = Get(s => s.Id == entity.Id);
                dbStorage = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
