using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Logger;
using Microsoft.AspNetCore.Mvc;
using RaspberryRobot;
using RaspberryRobotGpio;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    //TODO: Castle Windosor

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostRed()
        {
            var robot = new Robot();
            robot.RedLED(true);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostRedRelease()
        {

            var robot = new Robot();
            robot.RedLED(false);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostYellow()
        {
            var robot = new Robot();
            robot.YellowLED(true);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostYellowRelease()
        {
            var robot = new Robot();
            robot.YellowLED(false);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostGreen()
        {
            var robot = new Robot();
            robot.GreenLED(true);

            return View("Index");
        }


        [HttpPost]
        public IActionResult PostGreenRelease()
        {
            var robot = new Robot();
            robot.GreenLED(false);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostBlue()
        {
            var robot = new Robot();
            robot.BlueLED(true);

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostBlueRelease()
        {
            var robot = new Robot();
            robot.BlueLED(false);

            return View("Index");
        }

    }
}
