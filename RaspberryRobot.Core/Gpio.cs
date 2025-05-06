namespace RaspberryRobot.Core;

using RaspberryRobot.Core.Interfaces;
using System.Device.Gpio;

public class Gpio : IGpio
{
    private readonly int pinNumber;
    private readonly GpioController pinController;

    public Gpio(int pinNumber)
    {
        this.pinNumber = pinNumber;
        this.pinController = new GpioController();
        this.pinController.OpenPin(pinNumber, PinMode.Output);
    }

    public void Off()
    {
        this.pinController.Write(pinNumber, PinValue.Low);
    }

    public void On()
    {
        this.pinController.Write(pinNumber, PinValue.High);
    }

    public void Dispose()
    {
        if (this.pinController.IsPinOpen(this.pinNumber))
            this.pinController.ClosePin(this.pinNumber);

        this.pinController.Dispose();
    }
}
