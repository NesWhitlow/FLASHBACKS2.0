using AutoMapper;
using FLASHBACKS.Dtos;
using FLASHBACKS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLASHBACKS.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();


            // Dto to Domain
            CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            CreateMap<MovieDto, Movie>()
               .ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}