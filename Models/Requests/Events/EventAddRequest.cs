﻿using Models.Domain.Images;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sabio.Models.Requests.Events
{
    public class EventAddRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Headline { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        public string Slug { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public Image PrimaryImage { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        public decimal Latitude { get; set; }

        [Required]
        public decimal Longitude { get; set; }
    }
}