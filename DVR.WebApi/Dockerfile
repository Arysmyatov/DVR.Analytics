FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["../DVR.WebApi/DVR.WebApi/DVR.WebApi.csproj", "DVR.WebApi/"]
RUN dotnet restore "../DVR.WebApi/DVR.WebApi/DVR.WebApi.csproj"
COPY . .
WORKDIR "/src/DVR.WebApi"
RUN dotnet build "DVR.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DVR.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DVR.WebApi.dll"]
