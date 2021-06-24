using BlogProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Domain.Interfaces
{
    public interface IBlogRepository : IRepository<Blog>
    {
        List<Blog> GetAllByCategory(int categoryId);
        List<Blog> GetAllByTag(int tagId);
        Task AddWithCategories(Blog blog);
        Task AddWithTags(Blog blog);
    }
}
