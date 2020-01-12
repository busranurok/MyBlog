using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Find(Expression<Func<T, bool>> filter);
        int Save(T entity);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
