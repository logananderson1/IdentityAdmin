using Microsoft.AspNetCore.Mvc;

namespace IdentityAdmin.Web.Controllers;

public class ClientsController : ControllerBase
{
    // GET
    public async Task<IActionResult> Get()
    {
        return Ok("This is a test");
    }
}