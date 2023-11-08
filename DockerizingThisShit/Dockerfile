
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerizingThisShit/DockerizingThisShit.csproj", "DockerizingThisShit/"]
RUN dotnet restore "DockerizingThisShit/DockerizingThisShit.csproj"
COPY . .
WORKDIR "/src/DockerizingThisShit"
RUN dotnet build "DockerizingThisShit.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerizingThisShit.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerizingThisShit.dll"]