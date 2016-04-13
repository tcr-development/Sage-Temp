using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Tcr.Sage.Dal.I.Helpers {
   public class IncludesContainer<TEntity> where TEntity : class {

      public IEnumerable<Expression<Func<TEntity, object>>> Includes { get; private set; }

      public IncludesContainer(params Expression<Func<TEntity, object>>[] includes) {
         this.Includes = includes;
      }
   }
}