using System;

namespace RaspberryRobot
{
    public class DebugRobot : IRobot
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public void MoveForward()
        {
            Console.WriteLine("MoveForward");
        }

        public void MoveLeft()
        {
            Console.WriteLine("MoveLeft");
        }

        public void MoveReverse()
        {
            Console.WriteLine("MoveReverse");
        }

        public void MoveRight()
        {
            Console.WriteLine("MoveRight");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
