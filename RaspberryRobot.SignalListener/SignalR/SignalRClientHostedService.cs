namespace RaspberryRobot.SignalListener.SignalR;

public class SignalRClientHostedService : IHostedService
{
    private readonly SignalRClient _client;

    public SignalRClientHostedService(SignalRClient client)
    {
        _client = client;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await _client.StartAsync();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await _client.StopAsync();
    }
}
