FROM microsoft/dotnet:2.1-sdk AS builder

COPY ./src /app
WORKDIR /app
RUN dotnet publish -f netcoreapp2.1 -c Debug -o /publish

###

FROM microsoft/dotnet:2.1.3-aspnetcore-runtime
WORKDIR /app
COPY --from=builder /publish .

ENTRYPOINT ["/bin/bash", "-c", "dotnet WebApiApp.dll"]
