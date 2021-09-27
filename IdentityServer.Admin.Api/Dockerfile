#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["IdentityServer.Admin.Api/IdentityServer.Admin.Api.csproj", "IdentityServer.Admin.Api/"]
RUN dotnet restore "IdentityServer.Admin.Api/IdentityServer.Admin.Api.csproj"
COPY . .
WORKDIR "/src/IdentityServer.Admin.Api"
RUN dotnet build "IdentityServer.Admin.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityServer.Admin.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IdentityServer.Admin.Api.dll"]