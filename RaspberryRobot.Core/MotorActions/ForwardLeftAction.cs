using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core.MotorActions;

public class ForwardLeftAction : IMotorAction
{
    private readonly IGpio gpio;

    public ForwardLeftAction()
    {
        #if DEBUG
            this.gpio = new MockedGpio(1);
        #else
            this.gpio = new Gpio(12);
        #endif
    }

    public MotorActionTypeEnum ActionType => MotorActionTypeEnum.ForwardLeftAction;

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
