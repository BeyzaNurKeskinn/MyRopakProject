using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RopakProject.DataAccessLayer.Abstract;
using RopakProject.DataAccessLayer.Concreate;
using RopakProject.DataAccessLayer.Repositories;
using RopakProject.EntityLayer.Concrete;

namespace RopakProject.DataAccessLayer.Entity_Framework
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(Context context): base(context)
        {
                
        }
    }
}
