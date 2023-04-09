FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PalmLab4Main/PalmLab4Main.csproj", "PalmLab4Main/"]
RUN dotnet restore "PalmLab4Main/PalmLab4Main.csproj"
COPY . .
WORKDIR "/src/PalmLab4Main"
RUN dotnet build "PalmLab4Main.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PalmLab4Main.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PalmLab4Main.dll"]
