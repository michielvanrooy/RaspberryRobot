using System.Diagnostics;
using RaspberryRobot.Core.Interfaces;

namespace RaspberryRobot.Core;

public class Camera : ICamera
{
    private readonly string _imagePath = "/home/pi/images/capture.jpg";

    public byte[] CaptureImage()
    {
        string outputPath = "photo.jpg"; // Or any temp path you prefer

        //private string processArguments = $" -rot 180 -w 320 -h 240 -q 5 -o /home/pi/www/RaspberryPiWebsite/wwwroot/images/cameraOutput.jpg -tl 0.5 -t 99999999 -th 0:0:0";


        var startInfo = new ProcessStartInfo
        {
            FileName = "libcamera-jpeg",
            Arguments = $"-o {outputPath} --rotation 180 --width 320 --height 240 --quality 30 --timeout 10 -n",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (var process = new Process { StartInfo = startInfo })
        {
            process.Start();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                string error = process.StandardError.ReadToEnd();
                throw new Exception($"Camera capture failed: {error}");
            }
        }

        // Read the photo as byte array
        return File.ReadAllBytes(outputPath);
    }
}
