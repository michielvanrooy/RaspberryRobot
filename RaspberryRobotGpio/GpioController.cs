using System;
using System.IO;
using RaspberryRobotGpio.Enums;

namespace RaspberryRobotGpio
{
    public class GpioController : IGpioController
    {
        private readonly string gpioPath = "/sys/class/gpio/";
        private readonly int PinNumber;

        public GpioController(int pinNumber)
        {
            this.PinNumber = pinNumber;
            Init();
        }

        private void Init()
        {
            //Check if port is already open
            if (Directory.Exists($"{gpioPath}gpio{PinNumber.ToString()}"))
            {
                return;
            }

            File.WriteAllText($"{gpioPath}export", PinNumber.ToString());
            File.WriteAllText($"{gpioPath}gpio{PinNumber.ToString()}/direction", "out");
        }

        public void WritePin(PinValue value)
        {
            //TODO: Check if gpio is open, if not then open


            var valueStr = ((byte)value).ToString();
            File.WriteAllText($"{gpioPath}gpio{PinNumber.ToString()}/value", valueStr);
        }

        public void Dispose()
        {
            File.WriteAllText($"{gpioPath}unexport", PinNumber.ToString());
        }
    }
}


