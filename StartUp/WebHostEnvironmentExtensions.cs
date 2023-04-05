﻿using Microsoft.AspNetCore.Hosting;

namespace Sabio.Web.Api
{
    public static class WebHostEnvironmentExtensions
    {
        public static bool IsDevelopment(this IWebHostEnvironment env)
        {
            return env.EnvironmentName.ToLower().Equals("development");
        }
    }
}