using System.Collections.Generic;

namespace wcf.Domain.Interfaces.Repository
{
    public interface IRepositoyBaseDomain<TEntity> where TEntity:class
    {
        void Add(TEntity obj);
        void Delete(TEntity obj);
        void Delete(int id);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Update(int id);
    }
}
