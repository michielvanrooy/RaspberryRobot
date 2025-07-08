namespace RaspberryRobot.Api.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HealthzController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("This is all good, and baie baie Lekker.");
    }
}
