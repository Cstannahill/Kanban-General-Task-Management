namespace Sabio.Models.Requests.Addresses
{
    public class AddressUpdateRequest : AddressAddRequest, IModelIdentifier
    {
        public int Id { get; set; }
    }
}