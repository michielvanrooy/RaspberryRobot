using Microsoft.AspNetCore.Mvc;
using RaspberryCamera;
using RaspberryRobot;

namespace RaspberryRobotWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICamera raspberryCamera;

        public HomeController(ICamera raspberryCamera)
        {
            this.raspberryCamera = raspberryCamera;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostForward()
        {
            var robot = new Robot();
            robot.MoveForward();

            this.raspberryCamera.RefreshCamera();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostReverse()
        {
            var robot = new Robot();
            robot.MoveReverse();

            this.raspberryCamera.RefreshCamera();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostLeft()
        {
            var robot = new Robot();
            robot.MoveLeft();

            this.raspberryCamera.RefreshCamera();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostRight()
        {
            var robot = new Robot();
            robot.MoveRight();

            this.raspberryCamera.RefreshCamera();

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