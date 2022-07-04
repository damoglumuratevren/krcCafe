using CAFE.DataAxcess.Abstract;
using CAFE.DataAxcess.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.DataAxcess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        CafeContext context = new CafeContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Delete(T p)
        {
            var deletedEntity = context.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addEntity = context.Entry(p);
            addEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = context.Entry(p);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
