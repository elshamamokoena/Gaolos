﻿namespace Gaolos.Application.Features.ShoppingBasket.Commands.CreateBasketLine
{
    public class CreatedBasketLineVm
    {
        public Guid BasketLineId { get; set; }
        public Guid MenuItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}