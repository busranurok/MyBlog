using MyPersonalBlog.Business.Abstract;
using MyPersonalBlog.Concrete.EntityFramework;
using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Business.Concrete.Manager
{
    public class ArticleManager : IEntityRepositoryService<Article>, IArticleService
    {
        EfArticleDal _articleDal = new EfArticleDal();

        public Article Add(Article entity)
        {
            return _articleDal.Add(entity);
        }

        public void Delete(Article entity)
        {
            _articleDal.Delete(entity);
        }

        public Article Find(Expression<Func<Article, bool>> filter)
        {
            return _articleDal.Find(filter);
        }

        public Article Get(Expression<Func<Article, bool>> filter)
        {
            return _articleDal.Get(filter);
        }

        public List<Article> GetAll(Expression<Func<Article, bool>> filter = null)
        {
            return _articleDal.GetAll(filter);
        }

        public List<Article> GetAllWithUser(Expression<Func<Article, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Article GetWithUser(Expression<Func<Article, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            return _articleDal.Save();
        }

        public Article Update(Article entity)
        {
            return _articleDal.Update(entity);
        }
    }
}
