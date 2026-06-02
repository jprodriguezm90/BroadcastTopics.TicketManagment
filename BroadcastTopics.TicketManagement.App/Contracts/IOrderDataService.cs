using BroadcastTopics.TicketManagement.App.ViewModels;

namespace BroadcastTopics.TicketManagement.App.Contracts
{
    public interface IOrderDataService
    {
        Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size);
    }
}
