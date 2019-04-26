using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using wcf.Data.Context;
using wcf.Domain.Interfaces.Repository;

namespace wcf.Infra.Repository
{
    public class ReposiotyBaseInfra<TEntity> : IRepositoyBaseDomain<TEntity> where TEntity : class
    {
        private WcfDataContexto ctx;
        public ReposiotyBaseInfra()
        {
            ctx = new WcfDataContexto();
        }

        public void Add(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void Delete(TEntity obj)
        {
            ctx.Set<TEntity>().Remove(obj);
        }

        public void Delete(int id)
        {
            var obj = GetById(id);
            Delete(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return ctx.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public void Update(int id)
        {
            var obj = ctx.Set<TEntity>().Find(id);
            Update(obj);
        }
    }
}
