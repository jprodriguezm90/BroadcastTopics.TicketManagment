using AutoMapper;
using BroadcastTopics.TicketManagement.Application.Contracts.Persistence;
using BroadcastTopics.TicketManagement.Application.Features.Categories.Commands.CreateCategory;
using BroadcastTopics.TicketManagement.Application.Profiles;
using BroadcastTopics.TicketManagement.Application.UnitTests.Mocks;
using BroadcastTopics.TicketManagement.Domain.Entities;
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;

namespace BroadcastTopics.TicketManagement.Application.UnitTests.Categories.Commands
{
    public class CreateCategoryTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;
        private readonly ILoggerFactory _loggerFactory;

        public CreateCategoryTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            _loggerFactory = LoggerFactory.Create(builder => { });
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }, _loggerFactory);

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsAsync();
            allCategories.Count.ShouldBe(5);
        }
    }
}
