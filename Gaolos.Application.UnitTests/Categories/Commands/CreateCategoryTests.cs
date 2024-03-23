using AutoMapper;
using Gaolos.Application.Contracts.Persistence;
using Gaolos.Application.Features.Categories.Commands.CreateCateogry;
using Gaolos.Application.Profiles;
using Gaolos.Application.UnitTests.Mocks;
using Gaolos.Domain.Entities;
using Moq;
using Shouldly;

namespace Gaolos.Application.UnitTests.Categories.Commands
{
    public class CreateCategoryTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICategoryRepository> _mockCategoryRepository;

        public CreateCategoryTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.GetCategoriesAsync();
            allCategories.Count().ShouldBe(5);
        }
    }
}
