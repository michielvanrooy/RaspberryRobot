namespace RaspberryRobot.Core.Interfaces;

public interface IGpio : IDisposable
{
    void On();

    void Off();
}
