using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RopakProject.DtoLayer.Dtos.ProjectDto
{
    public class UpdateProjectDto
    {
        public int ProjectID { get; set; }
        [Required(ErrorMessage = "Lütfen makine numarasını yazınız")]
        public string ProjectNumber { get; set; }
        [Required(ErrorMessage = "Lütfen makine görseli giriniz")]
        public string ProjectCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen makine adı bilgisini giriniz")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter veri girişi yapınız")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen açıklamayı yazınız")]
        public string Description { get; set; }

    }
}
