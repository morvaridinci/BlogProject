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
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository = null;
        private readonly IMapper _mapper;

        public TagService(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<bool> Add(TagViewModel tag)
        {
            int i = await _tagRepository.Add(new Domain.Models.Tag
            {
                Name = tag.Name,
                CreatedAt = DateTime.Now
            });
            return i > 0;
        }

        public bool Update(TagViewModel tag)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TagViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TagViewModel> GetAll()
        {
            return _mapper.Map<List<TagViewModel>>(_tagRepository.GetAll());

        }
    }
}
