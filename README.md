# Transport For London Data Explorer
A simple C# MVC Web Application for viewing data from the Transport for London Unified API. 

![Alt text](/src/TFLDataExplorer/wwwroot/images/preview.png?raw=true "Screenshots of the main feature pages")


Main Features
=============

* Simple asynchronous Transport for London API bindings.
* Live Tube status and detailed description of delays.
* DLR line status.
* Current and future air quality forecasts.
* Station facility details.
* TeamCity build integration.
* Test coverage.


Pre-requisites:

Install Visual Studio 2015:

https://www.visualstudio.com/en-us/visual-studio-homepage-vs.aspx

Install .net Core and Visual Studio Tooling:

http://go.microsoft.com/fwlink/?LinkID=798306

Install Secret Manager:

https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets

Register for a free unique app_id from TFL:

https://api-portal.tfl.gov.uk/

Add your app_id and app_key to Secret Manager:

```
dotnet user-secrets set app_id [xxxxxx]
```
```
dotnet user-secrets set app_key [xxxxxx]
```

Install Json.Net from the Packager Manager Console:
```
PM> Install-Package Newtonsoft.Json 
```

There are a lot of improvements and fixes required (just see the [Kanban Board](https://github.com/timgrayson85/TFLDataExplorer/projects/1)) so please feel free to contribute!
