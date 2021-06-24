using BlogProject.Domain.Interfaces;
using BlogProject.Domain.Models;
using BlogProject.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly BlogDbContext _context = null;
        private DbSet<TEntity> _entities;

        public Repository(BlogDbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }
        public async Task<int> Add(TEntity entity)
        {

            _entities.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public int Delete(int id)
        {
            TEntity entity = _entities.FirstOrDefault(x => x.Id == id);
            if (entity == default) return -1;
            _entities.Remove(entity);
            return _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public TEntity GetById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);

        }

        public int Update(TEntity entity)
        {
            return _context.SaveChanges();
        }
    }
}
