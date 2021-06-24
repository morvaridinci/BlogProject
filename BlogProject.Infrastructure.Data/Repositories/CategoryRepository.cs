using BlogProject.Domain.Interfaces;
using BlogProject.Domain.Models;
using BlogProject.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Infrastructure.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        public CategoryRepository(BlogDbContext context) : base(context)
        {

        }
    }
}
