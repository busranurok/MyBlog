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
    public class SkillManager : IEntityRepositoryService<Skill>, ISkillService
    {
        EfSkillDal _skillDal = new EfSkillDal();

        public Skill Add(Skill entity)
        {
            return _skillDal.Add(entity);
        }

        public void Delete(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public Skill Find(Expression<Func<Skill, bool>> filter)
        {
            return _skillDal.Find(filter);
        }

        public Skill Get(Expression<Func<Skill, bool>> filter)
        {
            return _skillDal.Get(filter);
        }

        public List<Skill> GetAll(Expression<Func<Skill, bool>> filter = null)
        {
            return _skillDal.GetAll(filter);
        }

        public int Save()
        {
            return _skillDal.Save();
        }

        public Skill Update(Skill entity)
        {
            return _skillDal.Update(entity);
        }
    }
}
