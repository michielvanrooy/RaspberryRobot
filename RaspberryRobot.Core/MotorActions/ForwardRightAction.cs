using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core.MotorActions;

public class ForwardRightAction : IMotorAction
{
    private readonly IGpio gpio;

    public ForwardRightAction()
    {
        #if DEBUG
            this.gpio = new MockedGpio(2);
        #else
            this.gpio = new Gpio(20);
        #endif
    }

    public MotorActionTypeEnum ActionType => MotorActionTypeEnum.ForwardRightAction;

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
