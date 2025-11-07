
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using RegisterLoginJwt.Models;


namespace RegisterLoginJwt.Controllers;

#if DEBUG
[ApiController]
[Route("api/dev")]
public class DevController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;

    public DevController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpDelete("delete-admin")]
    public async Task<IActionResult> DeleteAdmin()
    {
        var admin = await _userManager.FindByEmailAsync("admin@example.com");
        if (admin != null)
        {
            await _userManager.DeleteAsync(admin);
            return Ok("Admin user deleted");
        }
        return NotFound("Admin user not found");
    }
}
#endif
