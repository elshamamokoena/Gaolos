
using Gaolos.Application.Models.MappingService;

namespace Gaolos.Application.Contracts.Persistence
{
    public interface IPropertyMappingService
    {
        Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>();
        bool ValidMappingExistsFor<TSource, TDestination>(string fields);
    }
}