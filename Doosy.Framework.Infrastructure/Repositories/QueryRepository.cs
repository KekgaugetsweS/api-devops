using System.Collections.Generic;
using System.Linq;
using Doosy.Framework.Domain;
using Microsoft.EntityFrameworkCore;

namespace Doosy.Infrastructure.Repositories
{
    public abstract class QueryRepository<T> : IQueryRepository<T> where T : Entity
    {
        protected DbContext context;

        public QueryRepository(DbContext context)
        {
            this.context = context;
        }

        public virtual IEnumerable<T> Filter<F>(F filter) where F : FilterRequest
        {
            return context.Set<T>();
        }

        public virtual T GetById(object id)
        {
            var item = context.Set<T>().Find(id);
            return item;
        }
    }
}
