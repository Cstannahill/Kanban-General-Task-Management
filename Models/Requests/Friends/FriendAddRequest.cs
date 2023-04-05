﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Sabio.Models.Requests.Friends
{
    public class FriendAddRequest
    {
        [Required]
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
        public string PrimaryImageUrl { get; set; }

        //public int UserId { get; set; }
    }
}