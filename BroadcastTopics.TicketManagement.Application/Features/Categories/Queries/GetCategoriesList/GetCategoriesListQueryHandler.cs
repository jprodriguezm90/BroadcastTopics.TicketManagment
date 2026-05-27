using AutoMapper;
using BroadcastTopics.TicketManagement.Application.Contracts.Persistence;
using BroadcastTopics.TicketManagement.Domain.Entities;
using MediatR;

namespace BroadcastTopics.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    internal class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryListVm>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListQueryHandler(IMapper mapper, IAsyncRepository<Category> categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryListVm>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var allCategories = (await _categoryRepository.ListAllAsAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<CategoryListVm>>(allCategories);
        }
    }
}
