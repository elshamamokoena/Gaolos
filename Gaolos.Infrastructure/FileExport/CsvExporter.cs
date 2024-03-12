using CsvHelper;
using Gaolos.Application.Contracts.Infrastructure;
using Gaolos.Application.Features.Restaurants.Queries.GetRestaurantsExport;

namespace Gaolos.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportRestaurantsToCsv(List<RestaurantExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter);
                csvWriter.WriteRecords(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}
