using System;

namespace RaspberryRobot
{
    public interface IRobot : IDisposable
    {
        //TODO: Delete LED Interface
        void RedLED(bool value);
        void YellowLED(bool value);
        void GreenLED(bool value);
        void BlueLED(bool value);

        void MoveForward();
        void MoveReverse();
        void MoveLeft();
        void MoveRight();
    }
}
