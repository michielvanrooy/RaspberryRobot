using RaspberryRobotGpio;
using RaspberryRobotGpio.Enums;

namespace RaspberryRobot
{
    //TODO: Castle Windosor

    public class Robot : IRobot
    {
        private const int redPin = 18;
        private const int yellowPin = 19;
        private const int greenPin = 20;
        private const int bluePin = 21;

        public void MoveForward()
        {
            WriteToGpio(PinValue.High, redPin);
            WriteToGpio(PinValue.High, yellowPin);
        }

        public void MoveReverse()
        {
            WriteToGpio(PinValue.High, greenPin);
            WriteToGpio(PinValue.High, bluePin);
        }

        public void MoveLeft()
        {
            WriteToGpio(PinValue.High, yellowPin);
            WriteToGpio(PinValue.High, greenPin);
        }

        public void MoveRight()
        {
            WriteToGpio(PinValue.High, redPin);
            WriteToGpio(PinValue.High, bluePin);
        }


        public void Stop()
        {
            WriteToGpio(PinValue.Low, redPin);
            WriteToGpio(PinValue.Low, yellowPin);
            WriteToGpio(PinValue.Low, greenPin);
            WriteToGpio(PinValue.Low, bluePin);
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

        private void WriteToGpio(PinValue pinValue, int pinNumber)
        {
            var gpio = new GpioController(pinNumber);
            gpio.WritePin(pinValue);
        }
    }
}
