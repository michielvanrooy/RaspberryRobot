# Make sure this is configured correctly
$piHost = "172.20.10.5"
$piUser = "pi"

$remoteCommands = @"
cd /var/www/html
sudo rm -rf RobotApi
unzip net8.0.zip
rm net8.0.zip
mv net8.0 RobotApi
sudo systemctl restart RaspberryPiRobot
"@

Write-Host "*** Starting build..."

dotnet build RaspberryRobot.sln -c Release

Write-Host "*** Build complete. Zipping output..."

Compress-Archive -Path "./RaspberryRobot.Api/bin/Release/net8.0/" -DestinationPath "./net8.0.zip"

Write-Host "*** Copy to Server via putty..."

pscp net8.0.zip "${piUser}@${piHost}:/var/www/html"

Write-Host "*** Delete Zip file..."

Remove-Item -Path "./net8.0.zip"

Write-Host "*** SSH into server..."

ssh "$piUser@$piHost" "$remoteCommands"

Write-Host "*** Done..."