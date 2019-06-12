using System;
using System.Diagnostics;
using System.Timers;

namespace RaspberryCamera
{
    public class Camera : ICamera
    {
        private string processName = "raspistill";
        private string processArguments = $" -rot 180 -w 320 -h 240 -q 5 -o /home/pi/www/RaspberryPiWebsite/wwwroot/images/cameraOutput.jpg -tl 0.5 -t 99999999 -th 0:0:0";

        private Process process;
        private DateTime stopTime;
        private int runningSeconds = 30;
        private Timer timer;

        public Camera()
        {
            timer = new Timer(10000);
            timer.Elapsed += OnStopCameraTimer;
            timer.Start();

            stopTime = new DateTime();

            process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = processName,
                    Arguments = processArguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
        }

        public void StartCamera()
        {
            process.Start();
        }

        public void RefreshCamera()
        {
            if (stopTime < DateTime.Now)
            {
                Console.WriteLine("-------------Refresh");
                StartCamera();
            }

            stopTime = DateTime.Now.AddSeconds(runningSeconds);
        }

        public void StopCamera()
        { 
            process.Kill();
        }

        private void OnStopCameraTimer(Object source, ElapsedEventArgs e)
        {
            //Check if camera should stop
            if(stopTime < DateTime.Now)
            {
                Console.WriteLine("-------- STOP!!!");
                this.StopCamera();
            }
        }
    }
}
