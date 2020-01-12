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
    public class SubscriberManager : IEntityRepositoryService<Subscriber>, ISubscriberService
    {
        EfSubscriberDal _subscriberDal = new EfSubscriberDal();

        public Subscriber Add(Subscriber entity)
        {
            return _subscriberDal.Add(entity);
        }

        public void Delete(Subscriber entity)
        {
            _subscriberDal.Delete(entity);
        }

        public Subscriber Find(Expression<Func<Subscriber, bool>> filter)
        {
            return _subscriberDal.Find(filter);
        }

        public Subscriber Get(Expression<Func<Subscriber, bool>> filter)
        {
            return _subscriberDal.Get(filter);
        }

        public List<Subscriber> GetAll(Expression<Func<Subscriber, bool>> filter = null)
        {
            return _subscriberDal.GetAll(filter);
        }

        public int Save()
        {
            return _subscriberDal.Save();
        }

        public Subscriber Update(Subscriber entity)
        {
            return _subscriberDal.Update(entity);
        }
    }
}
