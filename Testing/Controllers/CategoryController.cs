using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Testing.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Testing.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository repo;

        public CategoryController(ICategoryRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var categories = repo.GetAllCategories();

            return View(categories);
        }

        public IActionResult ViewCategory(int id)
        {
            var category = repo.GetCategory(id);

            return View(category);
        }

    }
}
