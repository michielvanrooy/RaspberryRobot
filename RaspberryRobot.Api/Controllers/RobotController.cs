using Microsoft.AspNetCore.Mvc;

namespace RaspberryRobot.Api.Controllers;

public class RobotController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Forward()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Reverse()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Left()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Right()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Stop()
    {
        return Ok();
    }
}
