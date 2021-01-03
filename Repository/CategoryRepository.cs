using Microsoft.EntityFrameworkCore;
using Skate.Database;
using Skate.Interfaces;
using Skate.Models;
using System.Collections.Generic;

namespace Skate.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SkateContextDb _db;

        public CategoryRepository(SkateContextDb db)
        {
            _db = db;
        }
        public void Create(Category category)
        {
            _db.Categories.Add(category);
            SaveChanges();
        }

        public void Delete(int id)
        {
            Category category = GetCategory(id);
            if (category != null)
            {
                _db.Categories.Remove(category);
                SaveChanges();
            }

        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _db.Categories;
        }

        public Category GetCategory(int id)
        {
            return _db.Categories.Find(id);
        }

        public void Update(Category category)
        {
            _db.Entry(category).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
