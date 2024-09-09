using SimpleCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUD.Repositories.Interfaces
{
    public interface IRepository<T, Int> where T : BaseEntity
    {
        //TODO: elimintar este metodo si es que conecta bien graphql
        //Task<T> GetById(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}
