﻿using Models.Domain.Images;
using System.Collections.Generic;

namespace Sabio.Models.Requests.Jobs
{
    public class JobAddRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Pay { get; set; }
        public string Slug { get; set; }
        public int StatusId { get; set; }
        public int UserId { get; set; }
        public Image PrimaryImage { get; set; }
        public List<string> Skills { get; set; }
        public int TechCompanyId { get; set; }
    }
}