
using AutoMapper;
using RopakProject.EntityLayer.Concrete;
using RopakProject.WebUI.Dtos.AboutDto;
using RopakProject.WebUI.Dtos.LoginDto;
using RopakProject.WebUI.Dtos.RegisterDto;
using RopakProject.WebUI.Dtos.ServiceDto;
using RopakProject.WebUI.Dtos.StaffDto;
using RopakProject.WebUI.Dtos.SubscribeDto;
using RopakProject.WebUI.Dtos.TestimonialDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RopakProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap(); 
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

        }
    }
}
