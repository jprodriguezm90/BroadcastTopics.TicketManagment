using BroadcastTopics.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BroadcastTopics.TicketManagement.Application.Contracts.Persistence
{
    internal interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}
