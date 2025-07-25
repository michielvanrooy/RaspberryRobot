using Microsoft.AspNetCore.SignalR;

namespace RaspberryRobot.SignalHub.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string sender, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", sender, message);
        }
    }
}
