using RopakProject.BusinessLayer.Abstract;
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
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult ProjectList()
        {
            var values = _projectService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProject(Project project)
        {
            _projectService.TInsert(project);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProject(int id)
        {
            var values = _projectService.TGetByID(id);
            _projectService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateProject(Project project)
        {
            _projectService.TUpdate(project);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProject(int id)
        {
            var values = _projectService.TGetByID(id);
            return Ok(values);
        }
    }
}
