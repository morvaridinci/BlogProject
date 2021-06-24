using AutoMapper;
using BlogProject.Application.Interfaces;
using BlogProject.Application.ViewModels;
using BlogProject.Domain.Interfaces;
using BlogProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Services
{
    public class BlogService :IBlogService

    {
        IBlogRepository _blogRepository = null;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<bool> Add(BlogViewModel blog)
        {
            blog.Categories = blog.SelectedCategories.Select(x => new CategoryViewModel { Id = x }).ToList();

            int id = await _blogRepository.Add(new Domain.Models.Blog
            {
                Article = blog.Article,
                CreatedAt = DateTime.Now,
                Title = blog.Title,
                UserId = blog.UserId,
                Categories = _mapper.Map<List<Category>>(blog.Categories),
                Tags = _mapper.Map<List<Tag>>(blog.Tags)
            });
            return id > 0;
        }

        public async Task AddWithCategories(BlogViewModel blog)
        {
            blog.Categories = blog.SelectedCategories.Select(x => new CategoryViewModel { Id = x }).ToList();
            await _blogRepository.AddWithCategories(_mapper.Map<Blog>(blog));
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BlogViewModel> GetAll()
        {
            return _mapper.Map<List<BlogViewModel>>(_blogRepository.GetAll());
        }

        public List<BlogViewModel> GetAllByCategory(int categoryId)
        {
            List<BlogViewModel> blogs = new List<BlogViewModel>();
            var currentBlogs = _blogRepository.GetAllByCategory(categoryId);
            foreach (var item in currentBlogs)
            {
                blogs.Add(new BlogViewModel
                {
                    Article = item.Article,
                    Title = item.Title,
                    Categories = _mapper.Map<List<CategoryViewModel>>(item.Categories)
                });
            }
            return blogs;
        }

        public BlogViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(BlogViewModel entity)
        {
            throw new NotImplementedException();
        }

        public async Task AddWithTags(BlogViewModel blog)
        {
            blog.Tags = blog.SelectedTags.Select(x => new TagViewModel { Id = x }).ToList();

            await _blogRepository.AddWithTags(_mapper.Map<Blog>(blog));
        }

        public List<BlogViewModel> GetAllByTag(int tagId)
        {
            List<BlogViewModel> blogs = new List<BlogViewModel>();
            var currentBlogs = _blogRepository.GetAllByTag(tagId);
            foreach (var item in currentBlogs)
            {
                blogs.Add(new BlogViewModel
                {
                    Article = item.Article,
                    Title = item.Title,
                    Tags = _mapper.Map<List<TagViewModel>>(item.Tags)
                });
            }
            return blogs;
        }
    }
}
