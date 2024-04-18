using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.ShoppingBasket.Commands.Checkout
{
    public class CheckoutCommand:IRequest<CheckoutCommandResponse>
    {
        public Guid BasketId { get; set; }

        //user info
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        // public string Country { get; set; }
           public Guid? UserId { get; set; }

        //payment information
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public string CardExpiration { get; set; }
        public string CvvCode { get; set; }
    }
}
