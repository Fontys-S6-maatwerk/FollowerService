FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

COPY . .
RUN dotnet restore ./FollowerService.Web

FROM build as dev
CMD ["dotnet", "watch", "--project", "/FollowerService.Web/FollowerService.Web.csproj", "run"]

FROM build AS publish
RUN dotnet publish FollowerService.Web/*.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FollowerService.Web.dll"]
