using AutoMapper;
using BroadcastTopics.TicketManagement.Application.Features.Categories.Commands.CreateCategory;
using BroadcastTopics.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using BroadcastTopics.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using BroadcastTopics.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using BroadcastTopics.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using BroadcastTopics.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using BroadcastTopics.TicketManagement.Application.Features.Events.Queries.GetEventList;
using BroadcastTopics.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using BroadcastTopics.TicketManagement.Application.Features.Orders.Queries.GetOrdersForMonth;
using BroadcastTopics.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BroadcastTopics.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVm>().ReverseMap();
            CreateMap<Category, CategoryEventListVm>().ReverseMap();
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();

            CreateMap<Order, OrdersForMonthDto>();

        }
    }
}
