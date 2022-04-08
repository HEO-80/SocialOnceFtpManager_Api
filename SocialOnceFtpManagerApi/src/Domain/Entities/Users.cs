using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAProductService.Domain.Entities
{
    public class Users : IdentityUser
    {
         
            public string Name { get; set; }

            public string SurName { get; set; }

            public string Linkedin { get; set; }


        }
    }
