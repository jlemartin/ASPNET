using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Testing.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection _conn;

        public CategoryRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _conn.Query<Category>("SELECT * FROM CATEGORIES;");
        }

        public Category GetCategory(int id)
        {
            return _conn.QuerySingle<Category>("SELECT * FROM CATEGORIES WHERE CATEGORYID = @id",
                new { id = id });

        }
    }
}
