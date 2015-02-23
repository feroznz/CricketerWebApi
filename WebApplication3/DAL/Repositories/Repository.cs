using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CricketersWebApi.DAL.Entities;
using WebApplication3.DAL;

namespace CricketersWebApi.DAL.Repositories
{
    public abstract class Repository<T>:IRepository<T> where T: EntityBase
    {
        private readonly StatsDbContext _context;

        protected Repository(StatsDbContext context)
        {
            _context = context;
        }
        public virtual List<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual T Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();

            return obj;
        }

        public virtual T Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public virtual int Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            return _context.SaveChanges();
        }
    }
}