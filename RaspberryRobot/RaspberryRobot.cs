using RaspberryRobotGpio;
using RaspberryRobotGpio.Enums;

namespace RaspberryRobot
{
    public class RaspberryRobot : IRaspberryRobot
    {
        private readonly IGpioController gpio;

        public RaspberryRobot()
        {
            gpio = new FakeGpioController(18);
        }

        public void RedLED(bool value) 
        {
            gpio.WritePin((value) ? PinValue.High : PinValue.Low);
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
