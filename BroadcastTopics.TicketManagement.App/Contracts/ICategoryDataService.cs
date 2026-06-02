using BroadcastTopics.TicketManagement.App.Services;
using BroadcastTopics.TicketManagement.App.Services.Base;
using BroadcastTopics.TicketManagement.App.ViewModels;

namespace BroadcastTopics.TicketManagement.App.Contracts
{
    public interface ICategoryDataService
    {
        Task<List<CategoryViewModel>> GetAllCategories();
        Task<List<CategoryEventsViewModel>> GetAllCategoriesWithEvents(bool includeHistory);
        Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel);
    }
}
