#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EvolutionSoft.API/EvolutionSoft.API.csproj", "EvolutionSoft.API/"]
COPY ["EvolutionSoft.Negocio/EvolutionSoft.Negocio.csproj", "EvolutionSoft.Negocio/"]
COPY ["EvolutionSoft.Infra/EvolutionSoft.Infra.csproj", "EvolutionSoft.Infra/"]
COPY ["EvolutionSoft.Models/EvolutionSoft.Models.csproj", "EvolutionSoft.Models/"]
RUN dotnet restore "EvolutionSoft.API/EvolutionSoft.API.csproj"
COPY . .
WORKDIR "/src/EvolutionSoft.API"
RUN dotnet build "EvolutionSoft.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EvolutionSoft.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EvolutionSoft.API.dll", "--environment=Development"]