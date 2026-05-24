using MediatR;
using System.Collections.Generic;

namespace BroadcastTopics.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery : IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
