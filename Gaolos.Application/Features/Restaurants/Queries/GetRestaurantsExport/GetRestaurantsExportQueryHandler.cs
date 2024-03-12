using AutoMapper;
using Gaolos.Application.Contracts.Infrastructure;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Domain.Entities;
using MediatR;

namespace Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport
{
    public class GetRestaurantsExportQueryHandler : IRequestHandler<GetRestaurantsExportQuery, RestaurantExportFileVm>
    {
        private readonly IAsyncRepository<Restaurant> _restaurantRepository;
        private readonly IMapper _mapper;
        private readonly ICsvExporter _csvExporter;

        public GetRestaurantsExportQueryHandler(IMapper mapper, IAsyncRepository<Restaurant> restaurantRepository, ICsvExporter csvExporter)
        {
            _mapper = mapper;
            _restaurantRepository = restaurantRepository;
            _csvExporter = csvExporter;
        }

        public async Task<RestaurantExportFileVm> Handle(GetRestaurantsExportQuery request, CancellationToken cancellationToken)
        {
            var allRestaurants = _mapper.Map<List<RestaurantExportDto>>((await _restaurantRepository.ListAllAsync()).OrderBy(x => x.Name));

            var fileData = _csvExporter.ExportRestaurantsToCsv(allRestaurants);

            var restExportFileDto = new RestaurantExportFileVm() { ContentType = "text/csv", Data = fileData, RestaurantExportFileName = $"{Guid.NewGuid()}.csv" };

            return restExportFileDto;
        }
    }
}