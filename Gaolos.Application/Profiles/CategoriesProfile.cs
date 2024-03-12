using AutoMapper;
using Gaolos.Application.Features.Categories.Commands.CreateCateogry;
using Gaolos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Profiles
{
    public class CategoriesProfile : Profile
    {
        public CategoriesProfile() 
        {
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();


        }
    }
}
