FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
ADD ./ /app
ENV ASPNETCORE_ENVIRONMENT=Production
WORKDIR /app
ENTRYPOINT ["dotnet", "ConsultaJuros.dll"]