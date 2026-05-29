using AutoMapper;
using BroadcastTopics.TicketManagement.Application.Contracts.Persistence;
using BroadcastTopics.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using BroadcastTopics.TicketManagement.Application.Profiles;
using BroadcastTopics.TicketManagement.Application.UnitTests.Mocks;
using BroadcastTopics.TicketManagement.Domain.Entities;
using Shouldly;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace BroadcastTopics.TicketManagement.Application.UnitTests.Categories.Queries
{
    public class GetCategoriesListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;
        private readonly ILoggerFactory _loggerFactory;

        public GetCategoriesListQueryHandlerTests()
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
        public async Task GetCategoriesListTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
