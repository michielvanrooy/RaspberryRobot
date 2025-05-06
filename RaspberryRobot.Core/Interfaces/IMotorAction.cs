using RaspberryRobot.Core.Enums;

namespace RaspberryRobot.Core.Interfaces;

public interface IMotorAction : IDisposable
{
    MotorActionTypeEnum ActionType { get; }

    void On();

    void Off();
}
