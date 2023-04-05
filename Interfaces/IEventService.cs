using Sabio.Models;
using Models.Domain.Events;
using Sabio.Models.Requests.Events;
using System;

namespace Sabio.Services.Interfaces
{
    public interface IEventService
    {
        public Paged<Event> Pagination(int pageIndex, int pageSize);

        public Paged<Event> SearchPaginated(int pageIndex, int pageSize, DateTime startDate, DateTime endDate);

        public Event Get(int id);

        public int Add(EventAddRequest request, int userId);

        public void Update(EventUpdateRequest request, int userId);
    }
}