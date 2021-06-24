using BlogProject.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Interfaces
{
    public interface IBlogService : IService<BlogViewModel>
    {
        List<BlogViewModel> GetAllByCategory(int categoryId);
        List<BlogViewModel> GetAllByTag(int tagId);
        Task AddWithCategories(BlogViewModel blog);
        Task AddWithTags(BlogViewModel blog);
    }
}
