using BroadcastTopics.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace BroadcastTopics.TicketManagement.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
