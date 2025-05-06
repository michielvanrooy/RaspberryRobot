using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core.MotorActions;

public class ForwardRightAction : IMotorAction
{
    private readonly IGpio gpio;

    public ForwardRightAction()
    {
        //TODO: If debug use Mocked and correct pin number
        this.gpio = new MockedGpio(2);
    }

    public MotorActionEnum ActionType => MotorActionEnum.ForwardRightAction;

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
