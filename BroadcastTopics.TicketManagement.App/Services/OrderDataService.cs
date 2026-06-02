using AutoMapper;
using Blazored.LocalStorage;
using BroadcastTopics.TicketManagement.App.Contracts;
using BroadcastTopics.TicketManagement.App.Services.Base;
using BroadcastTopics.TicketManagement.App.ViewModels;

namespace BroadcastTopics.TicketManagement.App.Services
{
    public class OrderDataService : BaseDataService, IOrderDataService
    {
        private readonly IMapper _mapper;

        public OrderDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size)
        {
            var orders = await _client.GetPagedOrdersForMonthAsync(date, page, size);
            var mappedOrders = _mapper.Map<PagedOrderForMonthViewModel>(orders);
            return mappedOrders;
        }
    }
}
