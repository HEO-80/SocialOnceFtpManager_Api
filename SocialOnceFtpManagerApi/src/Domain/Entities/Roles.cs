using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAProductService.Domain.Entities
{
    public class Roles : IdentityRole
    {

        public int RoleId { get; set; }
        public bool Enabled { get; set; }
        public string RoleName { get; set; }
        public string RoleUser { get; set; }

        //user can read posts
        public const string Reader = "Reader";

        //user can write posts
        public const string Writer = "Writer";

        //user can modify/delete posts
        public const string Moderator = "Moderator";

        //user can use mode user like Reader and Writer
        public const string User = "User";

        //user can do everything too
        public const string Manager = "Manager";

        //user can do everything
        public const string Administrator = "Administrator";


    }
}
