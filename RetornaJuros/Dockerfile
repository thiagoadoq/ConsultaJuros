FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["RetornaJuros.csproj", "RetornaJuros/"]
RUN dotnet restore "RetornaJuros/RetornaJuros.csproj"
COPY ./RetornaJuros ./RetornaJuros
WORKDIR "/src/RetornaJuros"
RUN dotnet build "RetornaJuros.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RetornaJuros.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ./CounterPage/build ./wwwroot

RUN useradd -m myappuser
USER myappuser

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet RetornaJuros.dll



