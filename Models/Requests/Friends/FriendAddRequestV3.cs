using Models.Domain.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sabio.Models.Requests.Friends
{
    public class FriendAddRequestV3
    {
        [Required]
        [MinLength(2)]
        public string Title { get; set; }

        [Required]
        public string Bio { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        public string Headline { get; set; }

        [Required]
        public string Slug { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int StatusId { get; set; }

        [Required]
        public Image PrimaryImage { get; set; }

        public List<string> Skills { get; set; }
    }
}