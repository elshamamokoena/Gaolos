using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos    .Application.Features.Categories.Queries.GetCategoriesList;
using Gaolos.Application.Profiles;
using Gaolos.Application.UnitTests.Mocks;
using Gaolos.Domain.Entities;
using Moq;
using Shouldly;

namespace Gaolos.Application.UnitTests.Categories.Queries
{
    public class GetCategoriesListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICategoryRepository> _mockCategoryRepository;

        public GetCategoriesListQueryHandlerTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesListTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

           // result.Count.ShouldBe(4);
        }
    }
}
