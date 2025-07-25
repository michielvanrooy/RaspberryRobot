namespace RaspberryRobot.SignalHub.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HealthzController : BaseController
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("The Hub is lekker.");
    }
}
