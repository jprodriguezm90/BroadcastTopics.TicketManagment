using BroadcastTopics.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BroadcastTopics.TicketManagement.Application.Contracts.Persistence
{
    internal interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}
