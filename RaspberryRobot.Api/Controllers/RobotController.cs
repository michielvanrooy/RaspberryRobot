using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RaspberryRobot.Api.Hubs;
using RaspberryRobot.Core.Constants;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Api.Controllers;

public class RobotController : BaseController
{
    private readonly IRobot robot;
    private readonly IHubContext<MessageHub> _hubContext;

    public RobotController(IRobot robot, IHubContext<MessageHub> hubContext)
    {
        this.robot = robot;
        this._hubContext = hubContext;
    }

    [HttpPost]
    public async Task<IActionResult> Forward()
    {
        try
        {
            robot.Forward();

            await this._hubContext.Clients.All.SendAsync("ReceiveMessage", "Michiel", RobotActions.Forward);

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

            await this._hubContext.Clients.All.SendAsync("ReceiveMessage", "Michiel", RobotActions.Reverse);

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

            await this._hubContext.Clients.All.SendAsync("ReceiveMessage", "Michiel", RobotActions.Left);

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

            await this._hubContext.Clients.All.SendAsync("ReceiveMessage", "Michiel", RobotActions.Right);

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

            await this._hubContext.Clients.All.SendAsync("ReceiveMessage", "Michiel", RobotActions.Stop);

            return Ok();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.ToString());
            throw;
        }
    }
}
