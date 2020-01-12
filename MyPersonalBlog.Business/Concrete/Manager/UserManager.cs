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
    public class UserManager : IEntityRepositoryService<User>, IUserService
    {
        EfUserDal _userDal = new EfUserDal();

        public User Add(User entity)
        {
            return _userDal.Add(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }

        public User Find(Expression<Func<User, bool>> filter)
        {
            return _userDal.Find(filter);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _userDal.Get(filter);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return _userDal.GetAll(filter);
        }

        public int Save()
        {
            return _userDal.Save();
        }

        public User Update(User entity)
        {
            return _userDal.Update(entity);
        }
    }
}
