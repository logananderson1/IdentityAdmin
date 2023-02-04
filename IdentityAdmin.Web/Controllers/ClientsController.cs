using Microsoft.AspNetCore.Mvc;

namespace IdentityAdmin.Web.Controllers;

public class ClientsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("This is a test");
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateClient()
    {
        return Ok("This is a test");
    }
}