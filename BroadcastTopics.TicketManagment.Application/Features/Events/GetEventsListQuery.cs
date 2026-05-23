using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BroadcastTopics.TicketManagement.Application.Features.Events
{
    internal class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
