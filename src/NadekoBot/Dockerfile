FROM microsoft/dotnet:1.1-sdk AS build-env
WORKDIR /app

# copy everything and build
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# build runtime image
FROM microsoft/dotnet:1.1-runtime
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["dotnet", "NadekoBot.dll"]