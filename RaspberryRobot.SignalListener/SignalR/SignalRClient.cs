namespace RaspberryRobot.SignalListener.SignalR;

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using RaspberryRobot.Core.Constants;
using RaspberryRobot.Core.Interfaces;

public class SignalRClient
{
    private readonly HubConnection _connection;
    private readonly IRobot robot;

    public SignalRClient(string hubUrl, IRobot robot)
    {
        this.robot = robot;

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

            switch (message)
            {
                case RobotActions.Forward:
                    this.robot.Forward();
                    break;
                case RobotActions.Reverse:
                    this.robot.Reverse();
                    break;
                case RobotActions.Left:
                    this.robot.Left();
                    break;
                case RobotActions.Right:
                    this.robot.Right();
                    break;
                default:
                    this.robot.Stop();
                    break;
            }
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

    //TODO: Delete this, might be used for photos from camara
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
