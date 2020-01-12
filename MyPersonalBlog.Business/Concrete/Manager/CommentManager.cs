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
    public class CommentManager : IEntityRepositoryService<Comment>, ICommentService
    {
        EfCommentDal _commentDal = new EfCommentDal();

        public Comment Add(Comment entity)
        {
            return _commentDal.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public Comment Find(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.Find(filter);
        }

        public Comment Get(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.Get(filter);
        }

        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.GetAll(filter);
        }

        public int Save()
        {
            return _commentDal.Save();
        }

        public Comment Update(Comment entity)
        {
            return _commentDal.Update(entity);
        }
    }
}
