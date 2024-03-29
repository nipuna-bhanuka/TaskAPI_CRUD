﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TaskAPI.Models;
using TaskAPI.Services.Dtos;

namespace TaskAPI.Services.Profiles
{
    public class AuthorProfile : AutoMapper.Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Address,
                opt => opt.MapFrom(src => $"{src.AddressNo}, {src.Street}, {src.City}")); // for projection

            CreateMap<CreateAuthorDto, Author>();
            CreateMap<UpdateAuthorDto, Author>();
        }
    }
}