FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["K9TitleBuilder/K9TitleBuilder.csproj", "K9TitleBuilder/"]
RUN dotnet restore "K9TitleBuilder/K9TitleBuilder.csproj"
COPY . .
WORKDIR "/src/K9TitleBuilder"
RUN dotnet build "K9TitleBuilder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "K9TitleBuilder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "K9TitleBuilder.dll"]