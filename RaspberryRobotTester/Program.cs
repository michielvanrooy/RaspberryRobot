using RaspberryRobot.Core;
using System;
using System.Threading;

namespace RaspberryRobotTester;

public class Program
{
    private static readonly bool IsOnRaspberry = true;

    public static void Main(string[] args)
    {
        Console.WriteLine("Which demo do you want to execute?");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Demo1();
                break;
            case "2":
                Demo2(); 
                break;
            default:
                Console.WriteLine("Invalid Selection");
                break;
        }
    }

    public static void Demo1()
    {
        Console.WriteLine("START");

        var gpio17 = new Gpio(17);
        var gpio16 = new Gpio(16);
        var gpio13 = new Gpio(13);
        var gpio12 = new Gpio(12);

        gpio17.On();

        Thread.Sleep(3000);
        gpio17.Off();
        gpio16.On();

        Thread.Sleep(3000);
        gpio16.Off();
        gpio13.On();

        Thread.Sleep(3000);
        gpio13.Off();
        gpio12.On();

        Thread.Sleep(3000);
        gpio12.Off();

        Console.WriteLine("Pins closing...");

        gpio17.Dispose();
        gpio16.Dispose();
        gpio13.Dispose();
        gpio12.Dispose();

        Console.WriteLine("Pins closed");

        Console.WriteLine("Press Enter to close");
        Console.ReadLine();

    }

    public static void Demo2()
    {
        var gpio18 = new Gpio(18);
        var gpio19 = new Gpio(19);
        var gpio20 = new Gpio(20);
        var gpio21 = new Gpio(21);

        Console.WriteLine("w - Forward");
        Console.WriteLine("a - left");
        Console.WriteLine("d - right");
        Console.WriteLine("s - backwards");
        Console.WriteLine("q - stop");
        Console.WriteLine("x - EXIT");

        var exit = false;

        while (!exit)
        {
            gpio18.Off();
            gpio19.Off();
            gpio20.Off();
            gpio21.Off();

            var input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case 'w':
                    gpio18.On();
                    gpio20.On();
                    Thread.Sleep(2000);
                    break;
                case 's':
                    gpio19.On();
                    gpio21.On();
                    Thread.Sleep(2000);
                    break;
                case 'a':
                    gpio18.On();
                    gpio21.On();
                    Thread.Sleep(2000);
                    break;
                case 'd':
                    gpio20.On();
                    gpio19.On();
                    Thread.Sleep(2000);
                    break;
                case 'q':
                    break;
                case 'x':
                    exit = true;
                    break;
                default:
                    break;
            }
        }

        gpio18.Dispose();
        gpio19.Dispose();
        gpio20.Dispose();
        gpio21.Dispose();
    }
}
