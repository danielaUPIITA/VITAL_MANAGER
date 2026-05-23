FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["VitalManager.API.csproj", "."]
RUN dotnet restore "VitalManager.API.csproj"
COPY . .
RUN dotnet build "VitalManager.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VitalManager.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VitalManager.API.dll"]
