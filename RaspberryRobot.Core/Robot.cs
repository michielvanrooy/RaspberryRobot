using RaspberryRobot.Core.Enums;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core;

public class Robot : IRobot
{
    private readonly MotorActionFactory motorActionFactory;

    public Robot(MotorActionFactory motorActionFactory)
    {
        this.motorActionFactory = motorActionFactory;
    }

    public void Forward() 
    {
        var forwardLeft = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ForwardLeftAction);
        var forwardRight = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ForwardRightAction);

        forwardLeft.On();
        forwardRight.On();
    }
    
    public void Reverse()
    {
        var reverseLeft = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ReverseLeftAction);
        var reverseRight = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ReverseRightAction);

        reverseLeft.On();
        reverseRight.On();
    }

    public void Left()
    {
        var forwardRight = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ForwardRightAction);
        var reverseLeft = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ReverseLeftAction);

        forwardRight.On();
        reverseLeft.On();
    }

    public void Right()
    {
        var forwardLeft = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ForwardLeftAction);
        var reverseRight = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ReverseRightAction);

        forwardLeft.On();
        reverseRight.On();
    }

    public void Stop()
    {
        var forwardLeft = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ForwardLeftAction);
        var forwardRight = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ForwardRightAction);
        var reverseLeft = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ReverseLeftAction);
        var reverseRight = this.motorActionFactory.GetMotorAction(MotorActionTypeEnum.ReverseRightAction);

        forwardLeft.Off();
        forwardRight.Off();
        reverseLeft.Off();
        reverseRight.Off();
    }
}
