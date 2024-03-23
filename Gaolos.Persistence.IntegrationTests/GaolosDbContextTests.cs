using Gaolos.Application.Contracts;
using Gaolos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;

namespace Gaolos.Persistence.IntegrationTests
{
    public class GaolosDbContextTests
    {
        private readonly GaolosDbContext _gaolosDbContext;
        private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public GaolosDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<GaolosDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _loggedInUserId = "00000000-0000-0000-0000-000000000000";
            _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _gaolosDbContext = new GaolosDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
        }

        [Fact]
        public async void Save_SetCreatedByProperty()
        {
            var res = new Restaurant() {RestaurantId = Guid.NewGuid(), Name = "Test restaurant" };

            _gaolosDbContext.Restaurants.Add(res);
            await _gaolosDbContext.SaveChangesAsync();

            res.CreatedBy.ShouldBe(_loggedInUserId);
        }
    }
}
