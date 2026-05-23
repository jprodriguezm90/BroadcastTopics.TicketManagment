using BroadcastTopics.TicketManagement.Application.Features.Events;
using MediatR;

namespace BroadcastTopics.TicketManagement.Application.Features.Events
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
