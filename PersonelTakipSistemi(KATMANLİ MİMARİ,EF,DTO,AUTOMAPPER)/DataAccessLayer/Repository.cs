using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;
using System.Data.Entity;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public class Repository<EntityT> : IRepository<EntityT> where EntityT : class
    {
        Context Database = new Context();
         DbSet<EntityT> Tablom;
        public Repository()
        {
            Tablom = Database.Set<EntityT>();
        }

        public int Delete(EntityT p)
        {
            Tablom.Remove(p);
            return Database.SaveChanges();
        }

        public EntityT Find(Expression<Func<EntityT, bool>> obj)
        {
            return Tablom.FirstOrDefault(obj);
        }

        public EntityT GetById(int id)
        {
            return Tablom.Find(id);
        }

        public List<EntityT> GetByFilter(Expression<Func<EntityT, bool>> filter)
        {
            return Tablom.Where(filter).ToList();
        }

        public int Insert(EntityT p)
        {
            Tablom.Add(p);
            return Database.SaveChanges();
        }

        public List<EntityT> List()
        {
            return Tablom.ToList();
        }

        public int Update(EntityT p)
        {
            return Database.SaveChanges();
        }
    }
}
