using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BroadcastTopics.TicketManagement.Application.Contracts.Persistence
{
    internal interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
