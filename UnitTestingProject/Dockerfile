FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["UnitTestingProject/UnitTestingProject.csproj", "UnitTestingProject/"]
RUN dotnet restore "UnitTestingProject/UnitTestingProject.csproj"
COPY . .
WORKDIR "/src/UnitTestingProject"
RUN dotnet build "UnitTestingProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UnitTestingProject.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UnitTestingProject.dll"]
