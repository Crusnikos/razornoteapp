FROM mcr.microsoft.com/dotnet/sdk:6.0 AS builder
WORKDIR /app

COPY *.sln .
COPY RazorPagesNoteManagerApp/*.csproj RazorPagesNoteManagerApp/
RUN dotnet restore RazorPagesNoteManagerApp.sln

COPY . ./
RUN dotnet build RazorPagesNoteManagerApp.sln -c Release --no-restore