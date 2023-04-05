using System.ComponentModel.DataAnnotations;

namespace Sabio.Models.Requests.Tasks
{
    public class TaskUpdateRequest : TaskAddRequest, IModelIdentifier
    {
        [Required]
        public int Id { get; set; }

        public string? Description { get; set; }
    }
}