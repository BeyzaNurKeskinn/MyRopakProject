using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RopakProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
       [Required(ErrorMessage ="Hizmet ikon linki giriniz.")]
        public string ServceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olabilir.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
