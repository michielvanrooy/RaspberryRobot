
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RaspberryCamera;
using System;
using WebCameraTest.Models;

namespace WebCameraTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings appSettings;
        private readonly ICamera raspberryCamera;

        public HomeController(ICamera raspberryCamera, IOptions<AppSettings> appSettings)
        {
            this.appSettings = appSettings.Value;
            this.raspberryCamera = raspberryCamera;
        }

        public IActionResult Index()
        {
            var filePath = appSettings.ImageFilePath;
            var model = new ImageModel() { ImagePath = filePath };

            return View(model);
        }

        public IActionResult Start()
        {

            Console.WriteLine("Controller says start");

            raspberryCamera.StartCamera();

            var filePath = appSettings.ImageFilePath;
            var model = new ImageModel() { ImagePath = filePath };

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Stop()
        {

            raspberryCamera.StopCamera();

            var filePath = appSettings.ImageFilePath;
            var model = new ImageModel() { ImagePath = filePath };

            return View("Index", model);
        }

    }
}
