using AutoMapper;
using BlogProject.Application.ViewModels;
using BlogProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProject.Application.Profiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<TagViewModel,Tag>();
            CreateMap<Tag,TagViewModel>();
        }
    }
}
