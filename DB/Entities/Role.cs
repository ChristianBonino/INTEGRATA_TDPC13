using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEGRATA_TDPC13.DB.Entities
{
    public class Role
    {
        public IdentityRole IdentityRole { get; set; }
        public List<IdentityRoleClaim<string>> RoleClaims { get; set; }
    }
}