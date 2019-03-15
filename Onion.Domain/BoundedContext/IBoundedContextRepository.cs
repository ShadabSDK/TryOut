using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Domain.BoundedContext
{
    interface IBoundedContextRepository : IRepository<BoundedContext>
    {
        List<BoundedContext> FetchAll();
        IQueryable<BoundedContext> Query { get; }
        void Add(BoundedContext entity);
        void Delete(BoundedContext entity);
        void Save();
    }
}
