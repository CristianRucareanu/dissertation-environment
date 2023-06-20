# syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /DissertationEnviroment
COPY BehavioursIntegrationConnectGOOGLE.csproj ./
RUN dotnet restore
COPY . .
RUN dotnet publish -c Debug -o publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /DissertationEnviroment
COPY --from=build-env /DissertationEnviroment/bin/Debug .
ENTRYPOINT ["dotnet", "BehavioursIntegrationConnectGOOGLE.dll"]