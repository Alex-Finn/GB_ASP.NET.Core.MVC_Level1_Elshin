using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.DomainEntities.Entities
{
    public class User : IdentityUser
    {
        public const string UserRole = "User";
        public const string AdminRole = "Admin";
        public const string AdminUser = "Admin";
        public const string TestUser = "TestUser";
    }
}
