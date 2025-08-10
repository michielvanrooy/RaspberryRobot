using Microsoft.AspNetCore.SignalR;

namespace RaspberryRobot.Api.Hubs;

public class MessageHub : Hub
{
    public async Task SendMessage(string sender, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", sender, message);
    }
}
