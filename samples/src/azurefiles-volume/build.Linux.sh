rm -r ./pkg/Linux
dotnet restore
dotnet publish -c Release -r ubuntu.16.04-x64 -o ./pkg/Linux/bin
cp VolumeTestApp.dockerfile ./pkg/Linux
