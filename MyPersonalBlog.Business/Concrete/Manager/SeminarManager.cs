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
    public class SeminarManager : IEntityRepositoryService<Seminar>, ISeminarService
    {
        EfSeminarDal _seminarDal = new EfSeminarDal();

        public Seminar Add(Seminar entity)
        {
            return _seminarDal.Add(entity);
        }

        public void Delete(Seminar entity)
        {
            _seminarDal.Delete(entity);
        }

        public Seminar Find(Expression<Func<Seminar, bool>> filter)
        {
            return _seminarDal.Find(filter);
        }

        public Seminar Get(Expression<Func<Seminar, bool>> filter)
        {
            return _seminarDal.Get(filter);
        }

        public List<Seminar> GetAll(Expression<Func<Seminar, bool>> filter = null)
        {
            return _seminarDal.GetAll(filter);
        }

        public int Save()
        {
            return _seminarDal.Save();
        }

        public Seminar Update(Seminar entity)
        {
            return _seminarDal.Update(entity);
        }
    }
}
