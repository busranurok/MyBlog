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
    public class EducationManager : IEntityRepositoryService<Education>, IEducationService
    {
        EfEducationDal _educationDal = new EfEducationDal();

        public Education Add(Education entity)
        {
            return _educationDal.Add(entity);
        }

        public void Delete(Education entity)
        {
            _educationDal.Delete(entity);
        }

        public Education Find(Expression<Func<Education, bool>> filter)
        {
            return _educationDal.Find(filter);
        }

        public Education Get(Expression<Func<Education, bool>> filter)
        {
            return _educationDal.Get(filter);
        }

        public List<Education> GetAll(Expression<Func<Education, bool>> filter = null)
        {
            return _educationDal.GetAll(filter);
        }

        public int Save()
        {
            return _educationDal.Save();
        }

        public Education Update(Education entity)
        {
            return _educationDal.Update(entity);
        }
    }
}
