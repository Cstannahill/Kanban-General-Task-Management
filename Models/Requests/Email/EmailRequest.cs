using System.ComponentModel.DataAnnotations;


namespace Sabio.Models.Requests
{
    public class EmailRequest
    {
        [Required]
        public SenderEmailRequest Sender { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MinLength(6), MaxLength(255)]
        public string RecipientEmail { get; set; }

        [Required]
        [MinLength(2), MaxLength(100)]
        public string SubjectLine { get; set; }

        [Required]
        [MinLength(2)]
        public string EmailMessage { get; set; }

        [Required]
        [MinLength(2), MaxLength(50)]
        public string RecipientName { get; set; }

        [Required]
        [MinLength(2)]
        public string Message { get; set; }

        [Required]
        [MinLength(2), MaxLength(50)]
        public string Token { get; set; }
    }
}