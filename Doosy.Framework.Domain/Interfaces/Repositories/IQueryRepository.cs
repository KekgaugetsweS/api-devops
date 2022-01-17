using System.Collections.Generic;

namespace Doosy.Framework.Domain
{
    public interface IQueryRepository<Ent> where Ent:Entity
    {
        IEnumerable<Ent> Filter<F>(F filter) where F : FilterRequest;
        Ent GetById(object id);
    }
}
