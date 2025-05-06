namespace RaspberryRobot.Robot.Interfaces;

public interface IGpio : IDisposable
{
    void On();

    void Off();
}
