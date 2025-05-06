using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core;

public class MockedGpio : IGpio
{
    private readonly int pinNumber;

    public MockedGpio(int pinNumber)
    {
        this.pinNumber = pinNumber;
    }

    public void Off()
    {
        Console.WriteLine($"Off: pin {pinNumber}");
    }

    public void On()
    {
        Console.WriteLine($"On: pin {pinNumber}");
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose: Object has been disposed");
    }
}
