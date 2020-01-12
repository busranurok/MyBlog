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
    public class CertificateManager : IEntityRepositoryService<Certificate>, ICertificateService
    {
        EfCertificateDal _certificateDal = new EfCertificateDal();

        public Certificate Add(Certificate entity)
        {
            return _certificateDal.Add(entity);
        }

        public void Delete(Certificate entity)
        {
            _certificateDal.Delete(entity);
        }

        public Certificate Find(Expression<Func<Certificate, bool>> filter)
        {
            return _certificateDal.Find(filter);
        }

        public Certificate Get(Expression<Func<Certificate, bool>> filter)
        {
            return _certificateDal.Get(filter);
        }

        public List<Certificate> GetAll(Expression<Func<Certificate, bool>> filter = null)
        {
            return _certificateDal.GetAll(filter);
        }

        public int Save()
        {
            return _certificateDal.Save();
        }

        public Certificate Update(Certificate entity)
        {
            return _certificateDal.Update(entity);
        }
    }
}
