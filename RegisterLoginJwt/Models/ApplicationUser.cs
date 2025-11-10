using Microsoft.AspNetCore.Identity;

namespace RegisterLoginJwt.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
}