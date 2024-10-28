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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {
        }

        public int GetContactCount()
        {
            var context = new Context();
            return context.Contacts.Count();
        }
    }
}
