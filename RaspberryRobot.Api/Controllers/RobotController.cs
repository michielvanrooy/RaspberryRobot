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
        try
        {
            robot.Forward();

            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.ToString());
            throw;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Reverse()
    {
        try
        {
            robot.Reverse();

            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.ToString());
            throw;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Left()
    {
        try
        {
            robot.Left();

            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.ToString());
            throw;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Right()
    {
        try
        {
            robot.Right();

            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.ToString());
            throw;
        }
    }

    [HttpPost]
    public async Task<IActionResult> Stop()
    {
        try
        {
            robot.Stop();

            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.ToString());
            throw;
        }
    }
}
