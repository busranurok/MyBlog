using MyPersonalBlog.Abstract;
using MyPersonalBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        private TContext _context;
        private DbSet<TEntity> _entity;

        public EfEntityRepositoryBase()
        {
            _context = new TContext();
            _entity = _context.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
            return entity;

        }

        public void Delete(TEntity entity)
        {

            var deleteEntity = _context.Entry(entity);
            deleteEntity.State = EntityState.Deleted;
            _context.SaveChanges();

        }

        public TEntity Find(Expression<Func<TEntity, bool>> filter)
        {
           return _entity.FirstOrDefault(filter);
        }

        public int Save()
        {
            var result = _context.SaveChanges();
            return result;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {

            return _entity.SingleOrDefault(filter);

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? _entity.ToList()
                    : _entity.Where(filter).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {

            var updateEntity = _context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            _context.SaveChanges();
            return entity;

        }

        public int Save(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
