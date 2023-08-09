# Getting Started

Install Docker. 

This repro was against Docker Desktop 4.22.0 (117440).

Install Dapr 

`winget install Dapr.CLI`

This repro was against:
- CLI version: 1.11.0
- Runtime version: 1.11.2

Then run:

`dapr init`

Open the solution in Visual Studio 17.7.

Set `docker-compose` as the startup project.

Hit Ctrl+F5 to run the project.

Open

`\Solutions\DaprBackEnd\Controllers\WeatherForecastController.cs`

and change one of the values of Summaries array.

Hot Reload will detect the change and apply it, but the new value is not available when you refresh https://localhost:50852/