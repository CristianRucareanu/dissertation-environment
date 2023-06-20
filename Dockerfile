# syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /DissertationEnviroment
COPY BehavioursIntegrationConnectGOOGLE.csproj ./
RUN dotnet restore
COPY . .
# RUN dotnet build BehavioursIntegrationConnectGOOGLE.csproj -o ./DissertationEnviroment
RUN dotnet publish -c Debug -o ./DissertationEnviroment

FROM build-env as runtime
WORKDIR /DissertationEnviroment
COPY --from=build-env ./DissertationEnviroment .
ENTRYPOINT ["dotnet", "BehavioursIntegrationConnectGOOGLE.dll"]