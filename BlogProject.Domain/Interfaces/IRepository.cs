using BlogProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<int> Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(int id);
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
