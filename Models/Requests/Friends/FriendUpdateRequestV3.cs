namespace Sabio.Models.Requests.Friends
{
    public class FriendUpdateRequestV3 : FriendAddRequestV3
    {
        public int Id { get; set; }

        public int PrimaryImageId { get; set; }
    }
}