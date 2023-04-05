namespace Sabio.Models.Requests.Tasks
{
    public class TaskLabelAddRequest
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int? TaskBoardId { get; set; }
    }
}