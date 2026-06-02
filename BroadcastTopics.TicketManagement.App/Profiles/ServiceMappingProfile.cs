using AutoMapper;
using BroadcastTopics.TicketManagement.App.ViewModels;
using System;

namespace BroadcastTopics.TicketManagement.App.Profiles
{
    // Mapping between generated service DTOs and client view models
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            // Map DateTimeOffset -> DateTime (use Utc)
            CreateMap<DateTimeOffset, DateTime>().ConvertUsing(src => src.UtcDateTime);

            // Service DTOs are in BroadcastTopics.TicketManagement.App.Services namespace
            // Configure mappings to view models
            CreateMap<BroadcastTopics.TicketManagement.App.Services.CategoryEventDto, EventNestedViewModel>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.UtcDateTime));

            CreateMap<BroadcastTopics.TicketManagement.App.Services.CategoryEventListVm, CategoryEventsViewModel>()
                .ForMember(dest => dest.Events, opt => opt.MapFrom(src => src.Events));

            // If needed map other service DTOs to view models here
        }
    }
}
