del /S /Q .\pkg\Windows
dotnet restore
dotnet publish -c Release -r win10-x64 -o .\pkg\Windows\bin
copy VolumeTestApp.dockerfile .\pkg\Windows