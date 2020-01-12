using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
        List<Article> GetAllWithUser(Expression<Func<Article, bool>> filter=null);
        Article GetWithUser(Expression<Func<Article, bool>> filter);
    }
}
