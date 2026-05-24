using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BroadcastTopics.TicketManagement.Application.Features.Events.Queries.GetEventList
{
    internal class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
