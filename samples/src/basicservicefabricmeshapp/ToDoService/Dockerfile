FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 20006

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ToDoService/ToDoService.csproj ToDoService/
RUN dotnet restore ToDoService/ToDoService.csproj
COPY . .
WORKDIR /src/ToDoService
RUN dotnet build ToDoService.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ToDoService.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ToDoService.dll"]