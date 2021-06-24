using BlogProject.Application.Interfaces;
using BlogProject.Application.ViewModels;
using BlogProject.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService = null;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryViewModel category)
        {
            await _categoryService.Add(category);
            return RedirectToAction("Add", "Blog");
        }
    }
}
