FROM microsoft/dotnet:2.0-runtime
ADD bin/ /VolumeTest/Code
ENTRYPOINT ["/VolumeTest/Code/VolumeTestApp"]
