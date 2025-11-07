using Microsoft.EntityFrameworkCore;
using RegisterLoginJwt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RegisterLoginJwt.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}