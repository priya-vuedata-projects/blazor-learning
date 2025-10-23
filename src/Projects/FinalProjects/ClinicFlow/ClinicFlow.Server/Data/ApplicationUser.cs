﻿using Microsoft.AspNetCore.Identity;

namespace ClinicFlow.Server.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
