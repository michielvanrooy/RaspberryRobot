namespace RaspberryRobot.SignalListener.SignalR;

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

public class SignalRClient
{
    private readonly HubConnection _connection;

    public SignalRClient(string hubUrl)
    {
        _connection = new HubConnectionBuilder()
            .WithUrl(hubUrl)
            .WithAutomaticReconnect()
            .Build();

        RegisterHandlers();
    }

    private void RegisterHandlers()
    {
        _connection.On<string, string>("ReceiveMessage", (sender, message) =>
        {
            Console.WriteLine($"📥 Received from {sender}: {message}");

            //TODO: execute message here

        });
    }

    public async Task StartAsync()
    {
        try
        {
            await _connection.StartAsync();
            Console.WriteLine("✅ SignalR client connected.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Failed to connect to SignalR hub: {ex.Message}");
        }
    }

    //TODO: Delete this, might be ised for photos from camara
    public async Task SendMessageAsync(string sender, string message)
    {
        try
        {
            await _connection.InvokeAsync("SendMessage", sender, message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Failed to send message: {ex.Message}");
        }
    }

    public async Task StopAsync()
    {
        await _connection.StopAsync();
        Console.WriteLine("🛑 SignalR client disconnected.");
    }
}
