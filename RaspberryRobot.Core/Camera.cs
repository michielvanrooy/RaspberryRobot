using System.Drawing;
using Iot.Device.Graphics;
using Iot.Device.Media;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core;

public class Camera : ICamera
{
    private readonly string _imagePath = "/home/pi/images/capture.jpg";

    public byte[] CaptureImage()
    {
        var settings = new VideoConnectionSettings(
            busId: 0,
            captureSize: (640, 480)
            //pixelFormat: PixelFormat..NV12 // Use NV12 to avoid green-tint issue
        );

        using VideoDevice device = VideoDevice.Create(settings);
        using MemoryStream ms = new MemoryStream(device.Capture());
        Color[] colors = VideoDevice.Nv12ToRgb(ms, settings.CaptureSize);
        using BitmapImage bitmap = VideoDevice.RgbToBitmap(settings.CaptureSize, colors);

        // Save image
        bitmap.SaveToFile(_imagePath, ImageFileType.Jpg);

        //File.WriteAllBytes(_imagePath, jpegStream.ToArray());

        // Return image file
        var fileBytes = System.IO.File.ReadAllBytes(_imagePath);
        return fileBytes;

        //return File(fileBytes, "image/jpeg", "capture.jpg");
    }
}
