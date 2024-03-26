﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.ResourceParameters
{
    public class RestaurantResourceParameters
    {
        const int maxPageSize = 24;
        public string ? Tag { get; set; }
        public string ? SearchQuery { get; set; }
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 12;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }
    }
}
