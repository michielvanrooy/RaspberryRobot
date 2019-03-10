using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Logger;
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

        //private const int sleepDelay = 3000;


        //private GpioController gpioRed = new GpioController(redPin);
        //private IGpioController gpioRed;

        public HomeController()
        {
            //gpioRed = new GpioController(redPin);
            //this.gpioRed = new GpioController(redPin);
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult PostRed()
        {
            var gpio = new GpioController(redPin);
            gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.High);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostRedRelease()
        {

            var gpio = new GpioController(redPin);
            gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);


            return View("Index");
        }



        [HttpPost]
        public IActionResult PostYellow()
        {
            var gpio = new GpioController(yellowPin);
            gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.High);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostYellowRelease()
        {
            var gpio = new GpioController(yellowPin);
            gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostGreen()
        {
            var gpio = new GpioController(greenPin);
            gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.High);

            return View("Index");
        }


        [HttpPost]
        public IActionResult PostGreenRelease()
        {
            var gpio = new GpioController(greenPin);
            gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostBlue()
        {
            var gpio = new GpioController(bluePin);
            gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.High);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostBlueRelease()
        {
            var gpio = new GpioController(bluePin);
            gpio.WritePin(RaspberryRobotGpio.Enums.PinValue.Low);

            return View("Index");
        }

    }
}
