
# Build runtime image
FROM mcr.microsoft.com/dotnet/core/runtime-deps:2.1-alpine3.9
WORKDIR /app
COPY ./SimpleAPI/build .
ENTRYPOINT ["./SimpleAPI"]