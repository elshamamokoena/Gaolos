﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsForCategory
{
    public class RestaurantsForCategoryDto
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
    }
}
