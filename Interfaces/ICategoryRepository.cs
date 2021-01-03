using Skate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skate.Interfaces
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        void Delete(int id);
        void Update(Category category);

        Category GetCategory(int id);
        IEnumerable<Category> GetAllCategories();
        void SaveChanges();
    }
}
