using BlogProject.Domain.Interfaces;
using BlogProject.Domain.Models;
using BlogProject.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Infrastructure.Data.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {

        public BlogRepository(BlogDbContext context) : base(context)
        {

        }

        public async Task AddWithCategories(Blog blog)
        {
            _context.Categories.AttachRange(blog.Categories);

            await base.Add(blog);

        }

        public Task AddWithTags(Blog blog)
        {
            _context.Tags.AttachRange(blog.Tags);
            return base.Add(blog);
        }

        public List<Blog> GetAllByCategory(int categoryId)
        {

            return _context.Blogs.Where(x => x.Categories.Any(y => y.Id == categoryId && y.Status)).ToList();
        }

        public List<Blog> GetAllByTag(int tagId)
        {
            return _context.Blogs.Where(x => x.Categories.Any(y => y.Id == tagId)).ToList();
        }
    }
}
