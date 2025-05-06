using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core.MotorActions;

public class ForwardLeftAction : IMotorAction
{
    private readonly IGpio gpio;

    public ForwardLeftAction()
    {
        //TODO: If debug use Mocked and correct pin number
        this.gpio = new MockedGpio(1);
    }

    public MotorActionEnum ActionType => MotorActionEnum.ForwardLeftAction;

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
