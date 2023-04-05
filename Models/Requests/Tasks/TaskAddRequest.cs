using System.ComponentModel.DataAnnotations;

namespace Sabio.Models.Requests.Tasks
{
    public class TaskAddRequest
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int Index { get; set; }
        [Required]
        public int TaskBoardId { get; set; }
    }
}