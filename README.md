## Table of contents

- [General info](#general-info)
- [Technologies](#technologies)
- [Setup](#setupen)

## General info

- Razor Pages Application to manage notes

## Technologies

- ASP.NET - Razor Pages
- PostgreSQL
- Docker

## Setup

```
1.docker compose build
2.docker compose up -d
3.docker compose exec razorpages bash
4.dotnet run --project RazorPagesNoteManagerApp/RazorPagesNoteManagerApp.csproj
```

Application should be available under adress: http://Localhost:5000
