using System;
using System.ComponentModel.DataAnnotations;


namespace Sabio.Models.Requests
{
    public class BoardInviteAddRequest
    {
        [Required]
        [MinLength(2), MaxLength(50)]
        public string Firstname { get; set; }
        [Required]
        [MinLength(2), MaxLength(50)]
        public string Lastname { get; set; }
        public string Email { get; set; }
        [Required]
        public Guid Token { get; set; }
        [Required]
        public int ExpirationSeconds { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int BoardId { get; set; }
        [Required]
        public string BoardName { get; set; }
    }
}
