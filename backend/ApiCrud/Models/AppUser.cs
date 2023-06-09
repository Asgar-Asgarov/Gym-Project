using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ApiCrud.Models
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; internal set; }
    }
}