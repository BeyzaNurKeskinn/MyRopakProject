using AutoMapper;
using RopakProject.BusinessLayer.Abstract;
using RopakProject.DtoLayer.Dtos.ProjectDto;
using RopakProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RopakProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Project2Controller : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper; //ctr+.
        public Project2Controller(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult Index()
        {
            var values = _projectService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProject(ProjectAddDto projectAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Project>(projectAddDto);
            _projectService.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProject(UpdateProjectDto updateProjectDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Project>(updateProjectDto);
            _projectService.TUpdate(values);
            return Ok("Başarıyla güncellendi.");
        }
    }
}
