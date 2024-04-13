﻿using Gaolos.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasket
{
    public class CreateBasketCommandResponse:BaseResponse
    {
        public CreateBasketCommandResponse():base()
        {

        }
        public CreateBasketDto Basket { get; set; }=default!;
    }
}
