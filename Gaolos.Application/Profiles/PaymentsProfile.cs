using AutoMapper;
using Gaolos.Application.Features.Account.Commands.PaymentMethods.AddPaymentMethod;
using Gaolos.Application.Features.Account.Commands.PaymentMethods.UpdatePaymentMethod;
using Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethod;
using Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethods;
using Gaolos.Domain.Entities.UserAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Profiles
{
    public class PaymentsProfile:Profile
    {
        public PaymentsProfile()
        {
            CreateMap<CreatePaymentMethodCommand, PaymentMethodForCreationDto>().ReverseMap();
            CreateMap<PaymentMethodForUpdateDto, UpdatePaymentMethodCommand>().ReverseMap();
            CreateMap<PaymentMethodVm, CreditCard>()
                .ReverseMap()
                .ForMember(dest=>dest.CardNumber,
                opt=>opt.MapFrom(src=>src.CreditCardNumber()));


            CreateMap<UpdatePaymentMethodCommand, CreditCard>().ReverseMap();
            CreateMap<CreditCardsVm, CreditCard>().ReverseMap()
                .ForMember(dest => dest.CardNumber,
                opt => opt.MapFrom(src => src.CreditCardNumber())); 

            CreateMap<CreditCard, CreatedPaymentMethodVm>().ReverseMap();
            CreateMap<CreatePaymentMethodCommand, CreditCard>().ReverseMap();
         
        }
    }
}
