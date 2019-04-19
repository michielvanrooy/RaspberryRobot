using System;

namespace RaspberryRobot
{
    public interface IRobot : IDisposable
    {
        void MoveForward();
        void MoveReverse();
        void MoveLeft();
        void MoveRight();
        void Stop();
    }
}
