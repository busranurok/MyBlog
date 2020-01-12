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
    public class AdditionalInfoManager : IEntityRepositoryService<AdditionalInfo>, IAdditionalInfoService
    {
        EfAdditionalInfoDal _additionalInfoDal = new EfAdditionalInfoDal();

        public AdditionalInfo Add(AdditionalInfo entity)
        {
            return _additionalInfoDal.Add(entity);
        }

        public void Delete(AdditionalInfo entity)
        {
            _additionalInfoDal.Delete(entity);
        }

        public AdditionalInfo Find(Expression<Func<AdditionalInfo, bool>> filter)
        {
            return _additionalInfoDal.Find(filter);
        }

        public AdditionalInfo Get(Expression<Func<AdditionalInfo, bool>> filter)
        {
            return _additionalInfoDal.Get(filter);
        }

        public List<AdditionalInfo> GetAll(Expression<Func<AdditionalInfo, bool>> filter = null)
        {
            return _additionalInfoDal.GetAll(filter);
        }

        public int Save()
        {
            return _additionalInfoDal.Save();
        }

        public AdditionalInfo Update(AdditionalInfo entity)
        {
            return _additionalInfoDal.Update(entity);
        }
    }
}
