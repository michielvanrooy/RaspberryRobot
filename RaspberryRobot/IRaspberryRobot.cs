using System;

namespace RaspberryRobot
{
    public interface IRaspberryRobot : IDisposable
    {
        void RedLED(bool value);
        //void YellowLED(bool value);
        //void GreenLED(bool value);
        //void BlueLED(bool value);
    }
}
