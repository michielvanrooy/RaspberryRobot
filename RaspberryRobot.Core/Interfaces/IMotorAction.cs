using RaspberryRobot.Core.Enums;

namespace RaspberryRobot.Core.Interfaces;

public interface IMotorAction : IDisposable
{
    MotorActionEnum ActionType { get; }

    void On();

    void Off();
}
