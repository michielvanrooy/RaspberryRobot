using Microsoft.AspNetCore.Mvc;
using RaspberryRobot;

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
            robot.MoveForward();

            return View("Index");
        }
       
        [HttpPost]
        public IActionResult PostYellow()
        {
            var robot = new Robot();
            robot.MoveReverse();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostGreen()
        {
            var robot = new Robot();
            robot.MoveLeft();

            return View("Index");
        }
        
        [HttpPost]
        public IActionResult PostBlue()
        {
            var robot = new Robot();
            robot.MoveRight();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostRedRelease()
        {

            var robot = new Robot();
            robot.Stop();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostYellowRelease()
        {
            var robot = new Robot();
            robot.Stop();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostGreenRelease()
        {
            var robot = new Robot();
            robot.Stop();

            return View("Index");
        }

        [HttpPost]
        public IActionResult PostBlueRelease()
        {
            var robot = new Robot();
            robot.Stop();

            return View("Index");
        }
    }
}
