using FluentValidation;
using Gaolos.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Restaurants.Commands.CreateRestaurant
{
    public class CreateRestaurantCommandValidator : AbstractValidator<CreateRestaurantCommand>
    {
        private readonly IRestaurantRepository _restaurantRepository;
        public CreateRestaurantCommandValidator(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            //RuleFor(p => p.Date)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .NotNull()
            //    .GreaterThan(DateTime.Now);

            //RuleFor(e => e)
            //    .MustAsync(EventNameAndDateUnique)
            //    .WithMessage("An event with the same name and date already exists.");

            //RuleFor(p => p.Price)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .GreaterThan(0);
        }

        //private async Task<bool> EventNameAndDateUnique(CreateMenuItemCommand e, CancellationToken token)
        //{
        //    return !await _eventRepository.IsEventNameAndDateUnique(e.Name, e.Date);
        //}
    }
}
