using AutoMapper;
using BroadcastTopics.TicketManagement.Application.Contracts.Persistence;
using BroadcastTopics.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BroadcastTopics.TicketManagement.Application.Features.Events.Queries.GetEventList
{
    internal class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVm>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }
}
