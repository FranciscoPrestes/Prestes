using System.Collections.Generic;

namespace Prestes.Cotacao.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetBy(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
