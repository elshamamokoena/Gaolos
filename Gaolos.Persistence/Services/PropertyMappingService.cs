
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Models.Category;
using Gaolos.Application.Models.MappingService;
using Gaolos.Application.Models.Order;
using Gaolos.Application.Models.Restaurant;
using Gaolos.Domain.Entities;

namespace Gaolos.Persistence.Services;

public class PropertyMappingService : IPropertyMappingService
{
    private readonly Dictionary<string, PropertyMappingValue> _restaurantPropertyMapping =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "RestaurantId", new(new[] { "RestaurantId" }) },
            { "Tags", new(new[] { "Tags" }) },
           // { "Age", new(new[] { "DateOfBirth" }, true) },
            { "Name", new(new[] { "Name" }) }
        };
    private readonly Dictionary<string, PropertyMappingValue> _categoryPropertyMapping =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "CategoryId", new(new[] { "CategoryId" }) },
            { "Name", new(new[] { "Name" }) }
        };

    private readonly Dictionary<string, PropertyMappingValue> _orderPropertyMapping =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "OrderId", new(new[] { "OrderId" }) },
            { "OrderPlaced", new(new[] { "OrderPlaced" }) },
            { "OrderStatus", new(new[] { "OrderStatus" }) },
            { "OrderTotal", new(new[] { "OrderTotal" }) }
        };

    private readonly IList<IPropertyMapping> _propertyMappings =
        new List<IPropertyMapping>();

    public PropertyMappingService()
    {
        _propertyMappings.Add(new PropertyMapping<RestaurantDto, Restaurant>
            ( _restaurantPropertyMapping));
        _propertyMappings.Add(new PropertyMapping<CategoryDto, Category>
            (_categoryPropertyMapping));
        _propertyMappings.Add(new PropertyMapping<OrderDto, Order>
            (_orderPropertyMapping));
    }

    public Dictionary<string, PropertyMappingValue> GetPropertyMapping
          <TSource, TDestination>()
    {
        // get matching mapping
        var matchingMapping = _propertyMappings
            .OfType<PropertyMapping<TSource, TDestination>>();

        if (matchingMapping.Count() == 1)
        {
            return matchingMapping.First().MappingDictionary;
        }

        throw new Exception($"Cannot find exact property mapping instance " +
            $"for <{typeof(TSource)},{typeof(TDestination)}");
    }

    public bool ValidMappingExistsFor<TSource, TDestination>(string fields)
    {
        var propertyMapping = GetPropertyMapping<TSource, TDestination>();

        if (string.IsNullOrWhiteSpace(fields))
        {
            return true;
        }

        // the string is separated by ",", so we split it.
        var fieldsAfterSplit = fields.Split(',');

        // run through the fields clauses
        foreach (var field in fieldsAfterSplit)
        {
            // trim
            var trimmedField = field.Trim();

            // remove everything after the first " " - if the fields 
            // are coming from an orderBy string, this part must be 
            // ignored
            var indexOfFirstSpace = trimmedField.IndexOf(" ");
            var propertyName = indexOfFirstSpace == -1 ?
                trimmedField : trimmedField.Remove(indexOfFirstSpace);

            // find the matching property
            if (!propertyMapping.ContainsKey(propertyName))
            {
                return false;
            }
        }
        return true;
    }
}

