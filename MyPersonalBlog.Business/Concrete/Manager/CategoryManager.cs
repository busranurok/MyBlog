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
    public class CategoryManager : IEntityRepositoryService<Category>, ICategoryService
    {
        EfCategoryDal _categoryDal = new EfCategoryDal();

        public Category Add(Category entity)
        {
            return _categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category Find(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Find(filter);
        }

        public Category Get(System.Linq.Expressions.Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Get(filter);
        }

        public List<Category> GetAll(System.Linq.Expressions.Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetAll(filter);
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.Find(x=> x.Id == id);
        }

        public int Save()
        {
            return _categoryDal.Save();
        }

        public Category Update(Category entity)
        {
            return _categoryDal.Update(entity);
        }
    }
}
