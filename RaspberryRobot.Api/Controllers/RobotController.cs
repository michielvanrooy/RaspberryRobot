using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RaspberryRobot.Api.Hubs;
using RaspberryRobot.Core.Constants;

namespace RaspberryRobot.Api.Controllers;

public class RobotController : BaseController
{
    private readonly IHubContext<MessageHub> _hubContext;

    public RobotController(IHubContext<MessageHub> hubContext)
    {
        this._hubContext = hubContext;
    }

    [HttpPost]
    public async Task<IActionResult> Forward()
    {
        try
        {
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
