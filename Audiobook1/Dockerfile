FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Set the working directory
WORKDIR /app

# Copy the solution file and restore dependencies
COPY *.sln .
COPY bol/bol.csproj ./bol/
COPY dal/dal.csproj ./dal/
COPY sol/sol.csproj ./sol/
COPY bll/bll.csproj ./bll/


COPY audiobook/audiobook.csproj ./audiobook/
RUN dotnet restore

# Copy the remaining files and build the application
COPY . .
RUN dotnet build

# Publish the project
WORKDIR /app/audiobook
RUN dotnet publish -c Release -o /app/out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/out .

# Expose the desired port
ENV ASPNETCORE_URLS=http://0.0.0.0:5000
EXPOSE 5000

# Start the application
ENTRYPOINT ["dotnet", "audiobook.dll"]