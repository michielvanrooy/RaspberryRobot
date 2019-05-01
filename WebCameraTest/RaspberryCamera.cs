using System.Diagnostics;
using System.IO;

namespace WebCameraTest
{
    public class RaspberryCamera
    {
        public void StartCamera()
        {

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "raspistill",
                    Arguments = $"-w 320 -h 240 -q 5 -o /var/www/CameraTestWebsite/wwwroot/images/test.png  -tl 0.3 -t 99999999 -th 0:0:0",
                    //Arguments = $"-w 640 -h 480 -q 5 -o /var/www/CameraTestWebsite/wwwroot/images/test.png  -tl 1 -t 99999999 -th 0:0:0",
                    //Arguments = $"-w 640 -h 480 -q 5 -o /var/www/CameraTestWebsite/wwwroot/images/test.png",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            //process.Start();
            //string result = process.StandardOutput.ReadToEnd();
            //process.WaitForExit();
        }
    }
}
