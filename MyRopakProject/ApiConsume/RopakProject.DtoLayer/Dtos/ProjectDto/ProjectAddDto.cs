using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RopakProject.DtoLayer.Dtos.ProjectDto
{
    public class ProjectAddDto
    {
       [Required(ErrorMessage ="Lütfen makine numarasını yazınız")]
        public string ProjectNumber { get; set; }
        public string ProjectCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen makine adı bilgisini giriniz")]
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
