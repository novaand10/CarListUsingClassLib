using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;

namespace DAL
{
    public class Repository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        public DBContext Context { get; set; }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
                Context = null;
            }
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            Context = (DBContext)DBContext.Create();
            return Context.Set<TEntity>();
        }
    }
}