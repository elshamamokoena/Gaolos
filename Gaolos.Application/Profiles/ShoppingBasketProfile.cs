using AutoMapper;
using Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasketLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Profiles
{
    public class ShoppingBasketProfile:Profile
    {
        public ShoppingBasketProfile()
        {
            CreateMap<BasketLineForCreationDto, CreateBasketLineCommand>().ReverseMap();
        }
    }
}
