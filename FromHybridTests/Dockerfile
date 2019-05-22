FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["FromHybridTests/FromHybridTests.csproj", "FromHybridTests/"]
RUN dotnet restore "FromHybridTests/FromHybridTests.csproj"
COPY . .
WORKDIR "/src/FromHybridTests"
RUN dotnet build "FromHybridTests.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FromHybridTests.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FromHybridTests.dll"]