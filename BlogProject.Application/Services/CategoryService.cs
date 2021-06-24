using AutoMapper;
using BlogProject.Application.Interfaces;
using BlogProject.Application.ViewModels;
using BlogProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository = null;
        private IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<bool> Add(CategoryViewModel category)
        {
            // _categoryRepository.Add(_mapper.Map(cate);
            int i=await _categoryRepository.Add(new Domain.Models.Category
            {
               Name = category.Name,
               Description = category.Description,
               CreatedAt = DateTime.Now
            });
            return i > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryViewModel> GetAll()
        {
            return _mapper.Map<List<CategoryViewModel>>(_categoryRepository.GetAll());
        }

        public CategoryViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoryViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
