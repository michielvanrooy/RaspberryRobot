using RaspberryRobotGpio;
using RaspberryRobotGpio.Enums;

namespace RaspberryRobot
{
    //TODO: Castle Windosor

    public class Robot : IRobot
    {
        //private readonly IGpioController gpio;
        private const int redPin = 18;
        private const int yellowPin = 19;
        private const int greenPin = 20;
        private const int bluePin = 21;

        public void RedLED(bool value) 
        {
            WriteToGpio((value) ? PinValue.High : PinValue.Low, redPin);
        }

        public void YellowLED(bool value)
        {
            WriteToGpio((value) ? PinValue.High : PinValue.Low, yellowPin);
        }

        public void GreenLED(bool value)
        {
            WriteToGpio((value) ? PinValue.High : PinValue.Low, greenPin);
        }

        public void BlueLED(bool value)
        {
            WriteToGpio((value) ? PinValue.High : PinValue.Low, bluePin);
        }

        private void WriteToGpio(PinValue pinValue, int pinNumber)
        {
            var gpio = new GpioController(pinNumber);
            gpio.WritePin(pinValue);
        }

        public void MoveForward()
        {
            throw new System.NotImplementedException();
        }

        public void MoveReverse()
        {
            throw new System.NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new System.NotImplementedException();
        }

        public void MoveRight()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            //TODO: This can be implemented beter

            var gpioRed = new GpioController(redPin);
            var gpioYellow = new GpioController(yellowPin);
            var gpioGreen = new GpioController(greenPin);
            var gpioBlue = new GpioController(bluePin);

            gpioRed.Dispose();
            gpioYellow.Dispose();
            gpioGreen.Dispose();
            gpioBlue.Dispose();
        }
    }
}
