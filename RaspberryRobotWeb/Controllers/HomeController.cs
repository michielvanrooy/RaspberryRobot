using Microsoft.AspNetCore.Mvc;
using RaspberryCamera;
using RaspberryRobot;

namespace RaspberryRobotWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICamera raspberryCamera;
        private readonly IRobot robot;

        public HomeController(ICamera raspberryCamera, IRobot robot)
        {
            this.raspberryCamera = raspberryCamera;
            this.robot = robot;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostForward()   
        {
            this.robot.MoveForward();
            this.raspberryCamera.RefreshCamera();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostReverse()
        {
            this.robot.MoveReverse();
            this.raspberryCamera.RefreshCamera();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostLeft()
        {
            this.robot.MoveLeft();

            this.raspberryCamera.RefreshCamera();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostRight()
        {
            this.robot.MoveRight();

            this.raspberryCamera.RefreshCamera();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostStop()
        {
            this.robot.Stop();
            
            return View("Index");
        }
    }
}