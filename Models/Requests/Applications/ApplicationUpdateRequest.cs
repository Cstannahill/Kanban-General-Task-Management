namespace Sabio.Models.Requests.Applications
{
    public class ApplicationUpdateRequest : ApplicationAddRequest, IModelIdentifier
    {
        public int Id { get; set; }
        public bool ReceivedCall { get; set; }
        public bool OfferedInterview { get; set; }
        public bool ReceivedOffer { get; set; }
        public string OfferAmount { get; set; }
    }
}