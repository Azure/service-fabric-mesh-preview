FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 9072

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY VotingWeb/VotingWeb.csproj VotingWeb/
# TODO - The following 2 lines are temporary until the nuget package is available from nuget.org
# Also the Microsoft.VisualStudio.Azure.SeaBreeze.Targets.0.3.0.nupkg should be copied to solution folder as a manual step
COPY VotingWeb/Nuget.Config ./
COPY Microsoft.VisualStudio.Azure.SeaBreeze.Targets.0.3.0.nupkg ./
RUN dotnet restore VotingWeb/VotingWeb.csproj
COPY . .
WORKDIR /src/VotingWeb
RUN dotnet build VotingWeb.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish VotingWeb.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VotingWeb.dll"]