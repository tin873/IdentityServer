#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["IdentityServer.Admin/IdentityServer.Admin.csproj", "IdentityServer.Admin/"]
COPY ["IdentityServer.Admin.EntityFramewokr.SqlServer/IdentityServer.Admin.EntityFramework.SqlServer.csproj", "IdentityServer.Admin.EntityFramewokr.SqlServer/"]
COPY ["IdentityServer.Admin.EntityFramework/IdentityServer.Admin.EntityFramework.csproj", "IdentityServer.Admin.EntityFramework/"]
COPY ["IdentityServer.Admin.EntityFramework.Extension/IdentityServer.Admin.EntityFramework.Extension.csproj", "IdentityServer.Admin.EntityFramework.Extension/"]
COPY ["IdentityServer.Admin.EntityFramework.Shared/IdentityServer.Admin.EntityFramework.Shared.csproj", "IdentityServer.Admin.EntityFramework.Shared/"]
COPY ["IdentityServer.Admin.EntityFramework.Còniguration/IdentityServer.Admin.EntityFramework.Configuration.csproj", "IdentityServer.Admin.EntityFramework.Còniguration/"]
COPY ["IdentityServer.Admin.EntityFramework.Identity/IdentityServer.Admin.EntityFramework.Identity.csproj", "IdentityServer.Admin.EntityFramework.Identity/"]
COPY ["IdentityServer.Admin.UI/IdentityServer.Admin.UI.csproj", "IdentityServer.Admin.UI/"]
COPY ["IdentityServer.Admin.BusinessLogic/IdentityServer.Admin.BusinessLogic.csproj", "IdentityServer.Admin.BusinessLogic/"]
COPY ["IdentityServer.Admin.BusinessLogic.Shared/IdentityServer.Admin.BusinessLogic.Shared.csproj", "IdentityServer.Admin.BusinessLogic.Shared/"]
COPY ["IdentityServer.Admin.BusinessLogic.Identity/IdentityServer.Admin.BusinessLogic.Identity.csproj", "IdentityServer.Admin.BusinessLogic.Identity/"]
COPY ["IdentityServer.Shared.Configuration/IdentityServer.Shared.Configuration.csproj", "IdentityServer.Shared.Configuration/"]
COPY ["IdentityServer.Admin.EntityFramework.MySql/IdentityServer.Admin.EntityFramework.MySql.csproj", "IdentityServer.Admin.EntityFramework.MySql/"]
COPY ["IdentityServer.Shared/IdentityServer.Shared.csproj", "IdentityServer.Shared/"]
COPY ["IdentityServer.Admin.EntityFramework.PostgreSQL/IdentityServer.Admin.EntityFramework.PostgreSQL.csproj", "IdentityServer.Admin.EntityFramework.PostgreSQL/"]
RUN dotnet restore "IdentityServer.Admin/IdentityServer.Admin.csproj"
COPY . .
WORKDIR "/src/IdentityServer.Admin"
RUN dotnet build "IdentityServer.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityServer.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IdentityServer.Admin.dll"]