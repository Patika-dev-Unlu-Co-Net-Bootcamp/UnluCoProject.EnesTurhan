﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAuthServer.Core.Dtos;
using UdemyAuthServer.Core.Models;
using UnluCoAuthServer.Core.Dtos;
using UnluCoAuthServer.Core.Models;

namespace UdemyAuthServer.Service
{
    internal class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
            
        }

    }
}
