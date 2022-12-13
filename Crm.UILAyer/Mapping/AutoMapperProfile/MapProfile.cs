using AutoMapper;
using Crm.DTO.DTOs.AnnouncementDTOs;
using Crm.DTO.DTOs.AppUserDTOs;
using Crm.DTO.DTOs.ProductDTOs;
using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILAyer.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Announcement, AnnouncementAddDto>();
            CreateMap<AnnouncementAddDto, Announcement>();


            CreateMap<Announcement, AnnouncementListDto>();
            CreateMap<AnnouncementListDto, Announcement>();

            CreateMap<Announcement, AnnouncementUpdateDto>();
            CreateMap<AnnouncementUpdateDto, Announcement>();

            CreateMap<AppUser, AppUserRegisterDto>();
            CreateMap<AppUserRegisterDto, AppUser>();
            
            
            CreateMap<Product, ProductAddDto>();
            CreateMap<ProductAddDto, Product>();


        }
    }
}
