FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-dev

WORKDIR /App
COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 
ENV language en
WORKDIR /Application
COPY --from=build-dev /App/out . 
ENTRYPOINT ["dotnet","dwes.dll"]