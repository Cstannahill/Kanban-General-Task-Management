namespace Sabio.Models.Requests
{
    public class EntityUpdateRequest : IModelIdentifier
    {
        //The Required Attribute is not required  b/c IModelIdentifier takes care of it
        public int Id { get; set; }
    }
}