#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ConsoleApp8/ConsoleApp8.csproj", "ConsoleApp8/"]
RUN dotnet restore "ConsoleApp8/ConsoleApp8.csproj"
COPY . .
WORKDIR "/src/ConsoleApp8"
RUN dotnet build "ConsoleApp8.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp8.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp8.dll"]