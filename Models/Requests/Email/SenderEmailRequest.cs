using System.ComponentModel.DataAnnotations;


namespace Sabio.Models.Requests
{
    public class SenderEmailRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [MinLength(6), MaxLength(255)]
        public string SenderEmail { get; set; }
        [Required]
        [MinLength(2), MaxLength(50)]
        public string SenderName { get; set; }
    }
}