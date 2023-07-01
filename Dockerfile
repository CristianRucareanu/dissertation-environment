# syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /DissertationEnviroment
COPY BehavioursIntegrationConnectGOOGLE.csproj ./
RUN 
COPY . .
RUN dotnet publish -c Debug -property:PublishDir=${`{env.DOTNET_ROOT`}}/myapp

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /DissertationEnviroment
COPY --from=build-env ["\\DissertationEnviroment" , "\\DissertationEnviroment"]
ENTRYPOINT ["dotnet", "bin/Debug/BehavioursIntegrationConnectGOOGLE.dll"]