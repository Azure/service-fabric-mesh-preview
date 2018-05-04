FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 8288

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY VotingData/VotingData.csproj VotingData/
# TODO - The following 2 lines are temporary until the nuget package is available from nuget.org
# Also the Microsoft.VisualStudio.Azure.SeaBreeze.Targets.0.3.0.nupkg should be copied to solution folder as a manual step
COPY VotingData/Nuget.Config ./
COPY Microsoft.VisualStudio.Azure.SeaBreeze.Targets.0.3.0.nupkg ./
RUN dotnet restore VotingData/VotingData.csproj
COPY . .
WORKDIR /src/VotingData
RUN dotnet build VotingData.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish VotingData.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VotingData.dll"]