namespace Sabio.Models.Requests.Events
{
    public class EventUpdateRequest : EventAddRequest, IModelIdentifier
    {
        public int Id { get; set; }
    }
}