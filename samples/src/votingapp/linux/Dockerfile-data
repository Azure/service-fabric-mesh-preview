FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY VotingData/VotingData.csproj VotingData/
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