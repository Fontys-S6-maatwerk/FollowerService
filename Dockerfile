FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FollowerService.Web/FollowerService.Web.csproj", "FollowerService.Web/"]
RUN dotnet restore "FollowerService.Web/FollowerService.Web.csproj"
COPY . .
WORKDIR "/src/FollowerService.Web"
RUN dotnet build "FollowerService.Web.csproj" -c Release -o /app/build

FROM build AS dev
WORKDIR "/src/FollowerService.Web"
ENTRYPOINT ["dotnet", "watch", "run", "--urls=http://+:5000"]

FROM build AS publish
RUN dotnet publish "FollowerService.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FollowerService.Web.dll"]