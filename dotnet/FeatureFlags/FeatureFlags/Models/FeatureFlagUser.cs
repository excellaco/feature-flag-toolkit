﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeatureFlags.Models
{
    public class FeatureFlagUser
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsLoggedIn { get; set; }

        public bool IsAdmin { get; set; }
    }
}
