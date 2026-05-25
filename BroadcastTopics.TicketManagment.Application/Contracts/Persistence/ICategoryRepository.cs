using BroadcastTopics.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BroadcastTopics.TicketManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
