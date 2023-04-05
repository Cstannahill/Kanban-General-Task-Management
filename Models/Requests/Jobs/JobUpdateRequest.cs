namespace Sabio.Models.Requests.Jobs
{
    public class JobUpdateRequest : JobAddRequest
    {
        public int Id { get; set; }

        public int PrimaryImageId { get; set; }
    }
}