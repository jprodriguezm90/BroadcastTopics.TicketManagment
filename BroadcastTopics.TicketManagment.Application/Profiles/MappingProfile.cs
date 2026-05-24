using AutoMapper;
using BroadcastTopics.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using BroadcastTopics.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using BroadcastTopics.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using BroadcastTopics.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using BroadcastTopics.TicketManagement.Application.Features.Events.Queries.GetEventList;
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

            CreateMap<Event, CreateEventCommand>().ReverseMap();

        }
    }
}
