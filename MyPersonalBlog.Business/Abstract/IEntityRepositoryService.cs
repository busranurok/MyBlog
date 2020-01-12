using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Business.Abstract
{
    public interface IEntityRepositoryService<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //IQueryable<T> ListQueryable();
        T Get(Expression<Func<T, bool>> filter);
        T Find(Expression<Func<T, bool>> filter);
        int Save();
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
