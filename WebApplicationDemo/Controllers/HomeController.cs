using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaspberryRobotGpio;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        private const int redPin = 18;
        private const int yellowPin = 19;
        private const int greenPin = 20;
        private const int bluePin = 21;

        private const int sleepDelay = 3000;


        private GpioController gpioRed = new GpioController(redPin);

        public IActionResult Index()
        {
            //gpioRed = new GpioController(redPin);
            return View();
        }

        

        [HttpPost]
        public IActionResult PostRed()
        {
            if (gpioRed is null)  //TODO: Fix this is null
            {
                using (var gpio = new GpioController(bluePin))
                {
                    gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.High);
                    Thread.Sleep(sleepDelay);
                    gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);
                }
            }
            else
            {

                gpioRed.WritePin(RaspberryRobotGpio.Enums.PinValue.High);
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostRedRelease()
        {
          
            //gpioRed.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);
           

            return View("Index");
        }

        

        [HttpPost]
        public IActionResult PostYellow()
        {
            using (var gpio = new GpioController(yellowPin))
            {
                gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.High);
                //Thread.Sleep(sleepDelay);
                //gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostYellowRelease()
        {
            using (var gpio = new GpioController(yellowPin))
            {
                gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostGreen()
        {
            using (var gpio = new GpioController(greenPin))
            {
                gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.High);
                //Thread.Sleep(sleepDelay);
                //gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);
            }

            return View("Index");
        }


        [HttpPost]
        public IActionResult PostGreenRelease()
        {
            using (var gpio = new GpioController(greenPin))
            {
                gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostBlue()
        {
            using (var gpio = new GpioController(bluePin))
            {
                gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.High);
                //Thread.Sleep(sleepDelay);
                //gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostBlueRelease()
        {
            using (var gpio = new GpioController(bluePin))
            {
                gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);
            }

            return View("Index");
        }

    }
}
