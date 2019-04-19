using System;
using RaspberryRobotGpio.Enums;

namespace RaspberryRobotGpio
{
    public class FakeGpioController : IGpioController
    {
        private readonly int PinNumber;

        public FakeGpioController(int pinNumber)
        {
            this.PinNumber = pinNumber;
            Init();
        }

        private void Init()
        {
            Console.WriteLine($"Gpio set up for pin {this.PinNumber}");
        }

        public void Dispose()
        {
            Console.WriteLine($"GPIO Pin {this.PinNumber} closed and disposed");
        }

        public void WritePin(PinValue value)
        {
            if (value == PinValue.High)
            {
                Console.WriteLine($"Pin {this.PinNumber} LED is on");
            }
            else
            {
                Console.WriteLine($"Pin {this.PinNumber} LED is off");
            }
        }
    }
}
