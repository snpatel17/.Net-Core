﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCloneWebAPI.Model
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }
}
