FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
<<<<<<< HEAD
ENTRYPOINT ["dotnet", "MIS.API.dll"]
=======
ENTRYPOINT ["dotnet", "aspnetapp.dll"]
>>>>>>> 2b374c13276d020bb9e6c81c0fb2006f1db9a65b
