#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PersonalWebsite.csproj", ""]
RUN dotnet restore "./PersonalWebsite.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PersonalWebsite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersonalWebsite.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PersonalWebsite.dll"]
