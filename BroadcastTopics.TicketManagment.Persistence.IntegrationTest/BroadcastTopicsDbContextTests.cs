using BroadcastTopics.TicketManagement.Application.Contracts;
using BroadcastTopics.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;

namespace BroadcastTopics.TicketManagement.Persistence.IntegrationTests
{
    public class BroadcastTopicsDbContextTests
    {
        private readonly BroadcastTopicsDbContext _broadcastTopicsDbContext;
        private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public BroadcastTopicsDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<BroadcastTopicsDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _loggedInUserId = "00000000-0000-0000-0000-000000000000";
            _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _broadcastTopicsDbContext = new BroadcastTopicsDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
        }

        [Fact]
        public async Task Save_SetCreatedByProperty()
        {
            var ev = new Event() {EventId = Guid.NewGuid(), Name = "Test event" };

            _broadcastTopicsDbContext.Events.Add(ev);
            await _broadcastTopicsDbContext.SaveChangesAsync();

            ev.CreatedBy.ShouldBe(_loggedInUserId);
        }
    }
}
