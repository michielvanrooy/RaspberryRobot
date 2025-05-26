using Microsoft.AspNetCore.Mvc;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Api.Controllers;

public class RobotController : BaseController
{
    private readonly IRobot robot;

    public RobotController(IRobot robot)
    {
        this.robot = robot;
    }

    [HttpPost]
    public async Task<IActionResult> Forward()
    {
        robot.Forward();

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Reverse()
    {
        robot.Reverse();

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Left()
    {
        robot.Left();

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Right()
    {
        robot.Right();

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Stop()
    {
        robot.Stop();

        return Ok();
    }
}
