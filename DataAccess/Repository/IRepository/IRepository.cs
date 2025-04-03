﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        public T Get(Expression<Func<T, bool>> filter, string? includeProperty = null);
        public void Add(T entity);
        public void Remove(T entity);
        public void RemoveRange(IEnumerable<T> entities);
    }
}
