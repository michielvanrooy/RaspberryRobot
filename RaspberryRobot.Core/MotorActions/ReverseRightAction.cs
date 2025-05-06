using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core.MotorActions;

public class ReverseRightAction : IMotorAction
{
    private readonly IGpio gpio;

    public ReverseRightAction()
    {
        //TODO: If debug use Mocked and correct pin number
        this.gpio = new MockedGpio(4);
    }

    public MotorActionEnum ActionType => MotorActionEnum.ReverseRightAction;
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
