using BroadcastTopics.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BroadcastTopics.TicketManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
