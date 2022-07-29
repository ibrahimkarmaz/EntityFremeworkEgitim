using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<EntityT>
    {
        int Insert(EntityT p);
        int Update(EntityT p);
        int Delete(EntityT p);
        List<EntityT> List();
        EntityT GetById(int id);

        EntityT Find(Expression<Func<EntityT,bool>> obj);
        List<EntityT> GetByFilter(Expression<Func<EntityT, bool>> filter);
    }
}
