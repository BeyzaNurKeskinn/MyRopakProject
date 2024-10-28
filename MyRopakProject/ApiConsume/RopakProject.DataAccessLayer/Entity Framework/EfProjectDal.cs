using RopakProject.DataAccessLayer.Abstract;
using RopakProject.DataAccessLayer.Concreate;
using RopakProject.DataAccessLayer.Repositories;
using RopakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RopakProject.DataAccessLayer.Entity_Framework
{
    public class EfProjectDal : GenericRepository<Project>, IProjectDal
    {
        public EfProjectDal(Context context): base(context)
        {

        }
    }
}
