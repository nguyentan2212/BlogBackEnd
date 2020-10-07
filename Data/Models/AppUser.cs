using Microsoft.AspNetCore.Identity;

namespace BlogBackEnd.Data.Models
{
    public class AppUser : IdentityUser<string>
    {
        public string FullName { get; set; }
    }
}