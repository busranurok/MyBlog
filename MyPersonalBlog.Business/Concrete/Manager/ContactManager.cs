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
    public class ContactManager : IEntityRepositoryService<Contact>, IContactService
    {
        EfContactDal _contactDal = new EfContactDal();

        public Contact Add(Contact entity)
        {
            return _contactDal.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact Find(Expression<Func<Contact, bool>> filter)
        {
            return _contactDal.Find(filter);
        }

        public Contact Get(Expression<Func<Contact, bool>> filter)
        {
            return _contactDal.Get(filter);
        }

        public List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null)
        {
            return _contactDal.GetAll(filter);
        }

        public int Save()
        {
            return _contactDal.Save();
        }

        public Contact Update(Contact entity)
        {
            return _contactDal.Update(entity);
        }
    }
}
