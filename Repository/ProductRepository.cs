using Microsoft.EntityFrameworkCore;
using Skate.Database;
using Skate.Interfaces;
using Skate.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Skate.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SkateContextDb _db;

        public ProductRepository(SkateContextDb db)
        {
            _db = db;
        }
        public void Create(Product product)
        {
            _db.Products.Add(product);
            SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = GetProduct(id);
            if (product != null)
            {
                _db.Products.Remove(product);
                SaveChanges();
            }
        }

        public void Update(Product product)
        {
            _db.Entry(product).State = EntityState.Modified;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _db.Products;
        }

        public Product GetProduct(int id)
        {
            return _db.Products.Find(id);
        }

        public IEnumerable<Product> GetByPredicate(Func<Product, Boolean> predicate)
        {
            return _db.Products.Where(predicate).ToList();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
