FROM microsoft/dotnet:2.1-runtime-nanoserver-sac2016
ADD bin/ /VolumeTest/Code
ENTRYPOINT ["/VolumeTest/Code/VolumeTestApp"]
