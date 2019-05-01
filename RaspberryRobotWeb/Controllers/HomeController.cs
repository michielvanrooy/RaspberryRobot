using Microsoft.AspNetCore.Mvc;
using RaspberryRobot;

namespace RaspberryRobotWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostForward()
        {
            var robot = new Robot();
            robot.MoveForward();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostReverse()
        {
            var robot = new Robot();
            robot.MoveReverse();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostLeft()
        {
            var robot = new Robot();
            robot.MoveLeft();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostRight()
        {
            var robot = new Robot();
            robot.MoveRight();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostStop()
        {

            var robot = new Robot();
            robot.Stop();

            return View("Index");
        }
    }
}