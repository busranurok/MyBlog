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
    public class LikedManager : IEntityRepositoryService<Liked>, ILikedService
    {
        EfLikedDal _likedDal = new EfLikedDal();

        public Liked Add(Liked entity)
        {
            return _likedDal.Add(entity);
        }

        public void Delete(Liked entity)
        {
            _likedDal.Delete(entity);
        }

        public Liked Find(Expression<Func<Liked, bool>> filter)
        {
            return _likedDal.Find(filter);
        }

        public Liked Get(Expression<Func<Liked, bool>> filter)
        {
            return _likedDal.Get(filter);
        }

        public List<Liked> GetAll(Expression<Func<Liked, bool>> filter = null)
        {
            return _likedDal.GetAll(filter);
        }

        public int Save()
        {
            return _likedDal.Save();
        }

        public Liked Update(Liked entity)
        {
            return _likedDal.Update(entity);
        }
    }
}
