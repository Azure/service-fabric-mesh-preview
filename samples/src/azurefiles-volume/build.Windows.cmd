del /S /Q .\pkg\Windows
dotnet restore
dotnet publish -c Release -r win10-x64 -o .\pkg\Windows\bin
copy VolumeTestApp.Windows.dockerfile .\pkg\Windows
pushd pkg\Windows\ && docker build -t volumetest:wincore1709 -f VolumeTestApp.Windows.dockerfile . && popd
docker run -v E:\service-fabric-mesh-preview\:C:\VolumeTest\Data\ volumetest:wincore1709
