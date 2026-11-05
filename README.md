# Babayode Movies (CSE 325 W02)

ASP.NET Core MVC movie app from the Microsoft "Get started with ASP.NET Core MVC" tutorial, on .NET 8 with SQLite.

Additions beyond the tutorial: app title with my name, my own movies in the seed data, a "My Favorite Movies" listing heading, a "released in or after" year filter, and padding on all form inputs.

## Run it

```
cd MvcMovie
dotnet tool install --global dotnet-ef --version 8.0.*
dotnet ef database update
dotnet run --launch-profile https
```

Then open the https URL shown in the terminal and go to `/Movies`.
