using MyPersonalBlog.Abstract;
using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Concrete.EntityFramework
{
    public class EfAdditionalInfoDal : EfEntityRepositoryBase<AdditionalInfo, EfBlogContext>, IAdditionalInfoDal
    {

    }
}
