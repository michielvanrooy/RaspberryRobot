using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RaspberryRobot.SignalHub.Hubs;

namespace RaspberryRobot.SignalHub.Controllers;

public class TestController : BaseController
{
    private readonly IHubContext<MessageHub> _hubContext;

    public TestController(IHubContext<MessageHub> hubContext)
    {
        _hubContext = hubContext;
    }

    [HttpPost("api/send")]
    public async Task<IActionResult> Send()
    {
        // Send message to all connected clients
        await this._hubContext.Clients.All.SendAsync("ReceiveMessage", "Michiel", "Hello Signal R world");

        return Ok("Message sent.");
    }
}


