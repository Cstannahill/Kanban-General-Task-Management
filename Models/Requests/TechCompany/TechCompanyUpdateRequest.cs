namespace Sabio.Models.Requests.TechCompany
{
    public class TechCompanyUpdateRequest : TechCompanyAddRequest, IModelIdentifier
    {
        public int Id { get; set; }
    }
}