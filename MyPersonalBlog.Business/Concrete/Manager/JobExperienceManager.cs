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
    public class JobExperienceManager : IEntityRepositoryService<JobExperience>, IJobExperienceService
    {
        EfJobExperienceDal _jobExperienceDal = new EfJobExperienceDal();

        public JobExperience Add(JobExperience entity)
        {
            return _jobExperienceDal.Add(entity);
        }

        public void Delete(JobExperience entity)
        {
            _jobExperienceDal.Delete(entity);
        }

        public JobExperience Find(Expression<Func<JobExperience, bool>> filter)
        {
            return _jobExperienceDal.Find(filter);
        }

        public JobExperience Get(Expression<Func<JobExperience, bool>> filter)
        {
            return _jobExperienceDal.Get(filter);
        }

        public List<JobExperience> GetAll(Expression<Func<JobExperience, bool>> filter = null)
        {
            return _jobExperienceDal.GetAll(filter);
        }

        public int Save()
        {
            return _jobExperienceDal.Save();
        }

        public JobExperience Update(JobExperience entity)
        {
            return _jobExperienceDal.Update(entity);
        }
    }
}
