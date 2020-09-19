FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY /DesignPatternsConsole/*.csproj ./DesignPatternsConsole
COPY /DesignPatternsLibrary/*.csproj ./DesignPatternsLibrary
COPY *.sln ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
LABEL org.opencontainers.image.source https://github.com/julianorinaldi/Design-Patterns
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "DesignPatternsConsole.dll"]