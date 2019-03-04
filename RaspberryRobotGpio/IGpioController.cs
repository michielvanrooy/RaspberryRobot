using System;
using RaspberryRobotGpio.Enums;

namespace RaspberryRobotGpio
{
    public interface IGpioController : IDisposable
    {
        void WritePin(PinValue value);
    }
}
