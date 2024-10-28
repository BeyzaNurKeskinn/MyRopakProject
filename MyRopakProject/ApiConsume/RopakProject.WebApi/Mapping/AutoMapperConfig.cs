using AutoMapper;
using RopakProject.DtoLayer.Dtos.ProjectDto;
using RopakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RopakProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ProjectAddDto, Project>();
            CreateMap<Project, ProjectAddDto>();

            CreateMap<UpdateProjectDto, Project>().ReverseMap();
        }
    }
}
