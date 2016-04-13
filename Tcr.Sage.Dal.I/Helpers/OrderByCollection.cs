using System;
using System.Collections.Generic;
using System.Linq;

namespace Tcr.Sage.Dal.I.Helpers {
   public sealed class OrderByCollection<TEntity> where TEntity : class {
      /// <summary>
      /// Gets the order by clause.
      /// </summary>
      /// <value>The clause.</value>
      public Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> Clause { get; private set; }

      /// <summary>
      /// Gets the order by then clauses.
      /// </summary>
      /// <value>The clauses.</value>
      public IEnumerable<Func<IOrderedQueryable<TEntity>, IOrderedQueryable<TEntity>>> Clauses { get; private set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="OrderByCollection{TEntity}" /> class.
      /// </summary>
      /// <param name="clause">The order by clause.</param>
      public OrderByCollection(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> clause) {
         this.Clause = clause;
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="OrderByCollection{TEntity}" /> class.
      /// </summary>
      /// <param name="clause">The order by clause.</param>
      /// <param name="clauses">The order by then clauses.</param>
      public OrderByCollection(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> clause, params Func<IOrderedQueryable<TEntity>, IOrderedQueryable<TEntity>>[] clauses)
          : this(clause) {
         this.Clauses = clauses;
      }
   }
}