using MyPersonalBlog.Abstract;
using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyPersonalBlog.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, EfBlogContext>, IArticleDal
    {
        public List<Article> GetAllWithUser(Expression<Func<Article, bool>> filter = null)

        {
            List<Article> articles = new List<Article>();
            using (EfBlogContext context = new EfBlogContext())
            {
                //context.Articles.Include(a=> a.User).Where(filter).ToList();
                articles = context.Articles.Include(a=> a.User).ToList();
            }
            return articles;
        }


        public Article GetWithUser(Expression<Func<Article, bool>> filter)
        {
            Article article = new Article();
            using (EfBlogContext context = new EfBlogContext())
            {
                article = context.Articles.Include(a=> a.User).FirstOrDefault(filter);
            }
            return article;
        }
    }
}
