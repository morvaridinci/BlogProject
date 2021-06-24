using AutoMapper;
using BlogProject.Application.ViewModels;
using BlogProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Application.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
