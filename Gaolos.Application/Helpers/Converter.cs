using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaolos.Application.Helpers
{
    public class Converter<TSource, TDestination> : ITypeConverter<PagedList<TSource>, PagedListDto<TDestination>>
    {
        public PagedListDto<TDestination> Convert(PagedList<TSource> source, PagedListDto<TDestination> destination, ResolutionContext context)
        {
            return new PagedListDto<TDestination>()
            {
                HasNext = source.HasNext,
                HasPrevious = source.HasPrevious,
                TotalCount = source.TotalCount,
                CurrentPage = source.CurrentPage,
                PageSize = source.PageSize,
                TotalPages = source.TotalPages,
                Subset = context.Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(source)
            };
        }
    }
}
