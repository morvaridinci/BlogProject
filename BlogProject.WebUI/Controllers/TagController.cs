using BlogProject.Application.Interfaces;
using BlogProject.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagService _tagService = null;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }
        public IActionResult AddTag()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTag(TagViewModel tag)
        {
           await _tagService.Add(tag);
            return RedirectToAction("Add", "Blog");
        }
    }
}
