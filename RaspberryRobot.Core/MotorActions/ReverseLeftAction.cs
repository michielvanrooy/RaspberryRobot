using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core.MotorActions;

public class ReverseLeftAction : IMotorAction
{
    private readonly IGpio gpio;

    public ReverseLeftAction()
    {
        //TODO: If debug use Mocked and correct pin number
        this.gpio = new MockedGpio(3);
    }

    public MotorActionEnum ActionType => MotorActionEnum.ReverseLeftAction;

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
