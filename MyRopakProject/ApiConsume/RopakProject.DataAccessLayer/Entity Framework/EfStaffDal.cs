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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal 
    {//ctortabtab
        public EfStaffDal (Context context) : base(context)
        {
                
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var value = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return value;
        }
    }
}
