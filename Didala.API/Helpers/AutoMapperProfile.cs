using System;
using AutoMapper;
using Didala.API.Models;

namespace Didala.API.Helpers

{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterModel, ApplicationUser>();

        }
    }
}
