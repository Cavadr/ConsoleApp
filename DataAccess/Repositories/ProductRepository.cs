using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DataAccess.Repositories
{

    public class ProductRepository : IRepository<Product>
    {
        public bool Create(Product entity)
        {
            try
            {
                DbContext.Products.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Product entity)
        {
            try
            {
                DbContext.Products.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product Get(Predicate<Product> filter = null)
        {
            try
            {
                return filter==null ? DbContext.Products[0]
                    : DbContext.Products.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetAll(Predicate<Product> filter = null)
        {
            return filter == null ? DbContext.Products
                    : DbContext.Products.FindAll(filter);
        }

        public bool Update(Product entity)
        {
            try
            {
                Product dbProduct = Get(p => p.Id == entity.Id);
                dbProduct = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }




}

