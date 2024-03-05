using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1CleanArchitecture.Domain.Entities;

namespace ClassLibrary1CleanArchitecture.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(Guid id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}