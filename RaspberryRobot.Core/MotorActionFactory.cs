using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core;

public class MotorActionFactory : IDisposable
{
    private readonly IEnumerable<IMotorAction> motorActions;

    public MotorActionFactory(IEnumerable<IMotorAction> motorActions)
    {
        this.motorActions = motorActions;
    }

    public void Dispose()
    {
        Console.WriteLine("Facory disposed");
    }

    public IMotorAction GetMotorAction(MotorActionTypeEnum actionType)
    {
        return this.motorActions.First(motorAction => motorAction.ActionType == actionType);
    }
}
