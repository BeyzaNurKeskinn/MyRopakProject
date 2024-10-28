using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RopakProject.WebUI.Dtos.ProjectDto
{
    public class CreateProjectDto
    {
        public string ProjectNumber { get; set; }
        public string ProjectCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
