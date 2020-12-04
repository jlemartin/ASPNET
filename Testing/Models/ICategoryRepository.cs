using System;
using System.Collections.Generic;

namespace Testing.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories();
        public Category GetCategory(int id);
    }
}
