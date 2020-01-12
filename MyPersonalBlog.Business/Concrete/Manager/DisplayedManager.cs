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
    public class DisplayedManager : IEntityRepositoryService<Displayed>, IDisplayedService
    {
        EfDisplayedDal _displayedDal = new EfDisplayedDal();

        public Displayed Add(Displayed entity)
        {
            return _displayedDal.Add(entity);
        }

        public void Delete(Displayed entity)
        {
            _displayedDal.Delete(entity);
        }

        public Displayed Find(Expression<Func<Displayed, bool>> filter)
        {
            return _displayedDal.Find(filter);
        }

        public Displayed Get(Expression<Func<Displayed, bool>> filter)
        {
            return _displayedDal.Get(filter);
        }

        public List<Displayed> GetAll(Expression<Func<Displayed, bool>> filter = null)
        {
            return _displayedDal.GetAll(filter);
        }

        public int Save()
        {
            return _displayedDal.Save();
        }

        public Displayed Update(Displayed entity)
        {
            return _displayedDal.Update(entity);
        }
    }
}
