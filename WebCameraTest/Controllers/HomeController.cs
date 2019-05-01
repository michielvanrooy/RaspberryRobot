
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebCameraTest.Models;

namespace WebCameraTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings appSettings;

        public HomeController(IOptions<AppSettings> appSettings)
        {
            this.appSettings = appSettings.Value;

            var cam = new RaspberryCamera();
            cam.StartCamera();
        }

        public IActionResult Index()
        {

            var filePath = appSettings.ImageFilePath;
            var model = new ImageModel() { ImagePath = filePath };



            return View(model);
        }
    }
}
