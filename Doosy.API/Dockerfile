#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
<<<<<<< HEAD
EXPOSE 80

 
>>>>>>> a60590bc87332c0c2149614c957e14bad45054b6
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Doosy.API/Doosy.API.csproj", "Doosy.API/"]
COPY ["Doosy.Domain/Doosy.Domain.csproj", "Doosy.Domain/"]
COPY ["Doosy.Framework.Domain/Doosy.Framework.Domain.csproj", "Doosy.Framework.Domain/"]
COPY ["Doosy.Infrastructure/Doosy.Infrastructure.csproj", "Doosy.Infrastructure/"]
COPY ["Doosy.Framework.Infrastructure/Doosy.Framework.Infrastructure.csproj", "Doosy.Framework.Infrastructure/"]
RUN dotnet restore "Doosy.API/Doosy.API.csproj"
COPY . .
WORKDIR "/src/Doosy.API"
RUN dotnet build "Doosy.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Doosy.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Doosy.API.dll"]