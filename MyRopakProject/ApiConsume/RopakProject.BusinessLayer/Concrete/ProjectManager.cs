﻿using RopakProject.BusinessLayer.Abstract;
using RopakProject.DataAccessLayer.Abstract;
using RopakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RopakProject.BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void TDelete(Project t)
        {
            _projectDal.Delete(t);
        }

        public Project TGetByID(int id)
        {
            return _projectDal.GetByID(id);
        }

        public List<Project> TGetList()
        {
            return _projectDal.GetList();
        }

        public void TInsert(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
