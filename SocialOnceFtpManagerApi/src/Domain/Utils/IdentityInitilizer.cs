using EAProductService.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAProductService.Domain.Utils
{
    public class IdentityInitilizer
    {

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            //Role Reader
            if (!roleManager.RoleExistsAsync(roleName: Roles.Reader).Result)
            {
                var role = new IdentityRole();
                role.Name = Roles.Reader;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

            //Role Writer
            if (!roleManager.RoleExistsAsync(roleName: Roles.Writer).Result)
            {
                var role = new IdentityRole();
                role.Name = Roles.Writer;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

            //Role Moderator
            if (!roleManager.RoleExistsAsync(roleName: Roles.Moderator).Result)
            {
                var role = new IdentityRole();
                role.Name = Roles.Moderator;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

            //Role User
            if (!roleManager.RoleExistsAsync(roleName: Roles.User).Result)
            {
                var role = new IdentityRole();
                role.Name = Roles.User;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

            //Role Manager
            if (!roleManager.RoleExistsAsync(roleName: Roles.Manager).Result)
            {
                var role = new IdentityRole();
                role.Name = Roles.Manager;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

            //Role Administrator
            if (!roleManager.RoleExistsAsync(roleName: Roles.Administrator).Result)
            {
                var role = new IdentityRole();
                role.Name = Roles.Administrator;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

        }

        public static void SeedUsers(UserManager<Users> userManager)
        {
            // Reader
            if (userManager.FindByNameAsync(Roles.Reader).Result == null)
            {
                var user = new Users();
                user.Name = Roles.Reader;
                user.Email = $"{ Roles.Reader }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: Roles.Reader).Wait();
                }
            }

            // Writer
            if (userManager.FindByNameAsync(Roles.Writer).Result == null)
            {
                var user = new Users();
                user.Name = Roles.Writer;
                user.Email = $"{ Roles.Writer }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: Roles.Writer).Wait();
                }
            }

            // Moderator
            if (userManager.FindByNameAsync(Roles.Moderator).Result == null)
            {
                var user = new Users();
                user.Name = Roles.Moderator;
                user.Email = $"{ Roles.Moderator }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: Roles.Moderator).Wait();
                }
            }

            // User
            if (userManager.FindByNameAsync(Roles.Reader).Result == null)
            {
                var user = new Users();
                user.Name = Roles.User;
                user.Email = $"{ Roles.User }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: Roles.User).Wait();
                }
            }


            // Manager
            if (userManager.FindByNameAsync(Roles.Reader).Result == null)
            {
                var user = new Users();
                user.Name = Roles.Manager;
                user.Email = $"{ Roles.Manager }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: Roles.Manager).Wait();
                }
            }

            // Administrator
            if (userManager.FindByNameAsync(Roles.Administrator).Result == null)
            {
                var user = new Users();
                user.Name = Roles.Administrator;
                user.Email = $"{ Roles.Administrator }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: Roles.Administrator).Wait();
                }
            }
        }

    }
}
