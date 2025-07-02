using Microsoft.AspNetCore.Mvc;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Api.Controllers;

public class CameraController : BaseController
{
    private readonly ICamera camera;

    public CameraController(ICamera camera)
    {
        this.camera = camera;
    }

    [HttpGet]
    public async Task<IActionResult> GetPhoto()
    {
        try
        {
            var photo = this.camera.CaptureImage();

            return Ok(photo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.ToString());
            throw;
        }
    }
}
