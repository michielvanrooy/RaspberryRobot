//using RaspberryRobotGpio;
//using RaspberryRobotGpio.Enums;
using System;
using System.Threading;
using System.Device.Gpio;

namespace RaspberryRobotTester
{
    public class Program
    {
        private static readonly bool IsOnRaspberry = true;
        //private static IGpioController gpio;
        //private static IGpioController gpio2;
        //private static IGpioController gpio3;
        //private static IGpioController gpio4;

        public static void Main(string[] args)
        { 
            Console.WriteLine("START");

            using var controller = new GpioController();

            //if (IsOnRaspberry)  
            //{
            //    gpio = new GpioController(18);
            //    gpio2 = new GpioController(19);
            //    gpio3 = new GpioController(20);
            //    gpio4 = new GpioController(21);
            //}
            //else
            //{
            //    gpio = new FakeGpioController(18);
            //    gpio2 = new FakeGpioController(19);
            //    gpio3 = new FakeGpioController(20);
            //    gpio4 = new FakeGpioController(21);
            //}

            controller.OpenPin(18, PinMode.Output);
            controller.OpenPin(19, PinMode.Output);
            controller.OpenPin(20, PinMode.Output);
            controller.OpenPin(21, PinMode.Output);

            Console.WriteLine("Pins opened");


            controller.Write(18, PinValue.High);
            //gpio.WritePin(PinValue.High);

            Thread.Sleep(3000);
            //gpio.WritePin(PinValue.Low);
            controller.Write(18, PinValue.Low);
            //gpio2.WritePin(PinValue.High);
            controller.Write(19, PinValue.High);

            Thread.Sleep(3000);
            //gpio2.WritePin(PinValue.Low);
            controller.Write(19, PinValue.Low);
            //gpio3.WritePin(PinValue.High);
            controller.Write(20, PinValue.High);

            Thread.Sleep(3000);
            //gpio3.WritePin(PinValue.Low);
            controller.Write(20, PinValue.Low);
            //gpio4.WritePin(PinValue.High);
            controller.Write(21, PinValue.High);

            Thread.Sleep(3000);
            //gpio4.WritePin(PinValue.Low);
            controller.Write(21, PinValue.Low);


            Console.WriteLine("Pins closing...");

            if (controller.IsPinOpen(18))
                controller.ClosePin(18);
            if (controller.IsPinOpen(19))
                controller.ClosePin(19);
            if (controller.IsPinOpen(20))
                controller.ClosePin(20);
            if (controller.IsPinOpen(21))
                controller.ClosePin(21);

            Console.WriteLine("Pins closed");

            //gpio.Dispose();
            //gpio2.Dispose();
            //gpio3.Dispose();
            //gpio4.Dispose();


            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}
