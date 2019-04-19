using RaspberryRobotGpio;
using RaspberryRobotGpio.Enums;
using System;
using System.Threading;

namespace RaspberryRobotTester
{
    public class Program
    {
        private static readonly bool IsOnRaspberry = true;
        private static IGpioController gpio;
        private static IGpioController gpio2;
        private static IGpioController gpio3;
        private static IGpioController gpio4;

        public static void Main(string[] args)
        {
            if (IsOnRaspberry)  
            {
                gpio = new GpioController(18);
                gpio2 = new GpioController(19);
                gpio3 = new GpioController(20);
                gpio4 = new GpioController(21);
            }
            else
            {
                gpio = new FakeGpioController(18);
                gpio2 = new FakeGpioController(19);
                gpio3 = new FakeGpioController(20);
                gpio4 = new FakeGpioController(21);
            }
            
            gpio.WritePin(PinValue.High);

            Thread.Sleep(3000);
            gpio.WritePin(PinValue.Low);
            gpio2.WritePin(PinValue.High);

            Thread.Sleep(3000);
            gpio2.WritePin(PinValue.Low);
            gpio3.WritePin(PinValue.High);

            Thread.Sleep(3000);
            gpio3.WritePin(PinValue.Low);
            gpio4.WritePin(PinValue.High);

            Thread.Sleep(3000);
            gpio4.WritePin(PinValue.Low);


            gpio.Dispose();
            gpio2.Dispose();
            gpio3.Dispose();
            gpio4.Dispose();


            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}
