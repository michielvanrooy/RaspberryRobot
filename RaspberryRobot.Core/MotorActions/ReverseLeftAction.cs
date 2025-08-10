using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core.MotorActions;

public class ReverseLeftAction : IMotorAction
{
    private readonly IGpio gpio;

    public ReverseLeftAction()
    {
        #if DEBUG
            this.gpio = new MockedGpio(3);
        #else
            this.gpio = new Gpio(16);
        #endif
    }

    public MotorActionTypeEnum ActionType => MotorActionTypeEnum.ReverseLeftAction;

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
