﻿using System;
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
    public class EfServiceDal : GenericRepository<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {

        }
    }
}
