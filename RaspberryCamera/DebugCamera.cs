using System;

namespace RaspberryCamera
{
    public class DebugCamera : ICamera
    {
        public void RefreshCamera()
        {
            Console.WriteLine("RefreshCamera");
        }

        public void StartCamera()
        {
            Console.WriteLine("StartCamera");
        }

        public void StopCamera()
        {
            Console.WriteLine("StopCamera");
        }
    }
}
