using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core.MotorActions;

public class ReverseRightAction : IMotorAction
{
    private readonly IGpio gpio;

    public ReverseRightAction()
    {
        #if DEBUG
            this.gpio = new MockedGpio(4);
        #else
            this.gpio = new Gpio(21);
        #endif
    }

    public MotorActionTypeEnum ActionType => MotorActionTypeEnum.ReverseRightAction;
    public void Off()
    {
        gpio.Off();
    }

    public void On()
    {
        gpio.On();
    }

    public void Dispose()
    {
        gpio.Dispose();
    }
}
