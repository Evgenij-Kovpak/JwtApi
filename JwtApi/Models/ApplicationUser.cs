using System.Collections.Generic;
using JwtApi.Entities;
using Microsoft.AspNetCore.Identity;

namespace JwtApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}
