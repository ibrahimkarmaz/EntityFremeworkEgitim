using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer.Entities;

namespace BusinessLayer
{
    public class DepartmanManager
    {
        Repository<Departman> repositoryDepartman = new Repository<Departman>();
        public List<Departman> DepartmanListele()
        {
            return repositoryDepartman.List();
        }

    }
}
