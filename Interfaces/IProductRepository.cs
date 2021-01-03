using Skate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skate.Interfaces
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Delete(int id);
        void Update(Product product);

        Product GetProduct(int id);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetByPredicate(Func<Product, Boolean> predicate);
        void SaveChanges();
    }
}
