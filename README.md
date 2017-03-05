# TFLDataExplorer
A simple C# MVC Web Application for viewing data from the Transport for London Unified API. 

![Alt text](/src/TFLDataExplorer/wwwroot/images/preview.jpg?raw=true "Tube Status")

![alt tag](https://github.com/timgrayson85/TFLDataExplorer/blob/master/preview2.jpg)

Pre-requisites:

Install Visual Studio 2015:

https://www.visualstudio.com/en-us/visual-studio-homepage-vs.aspx

Install .net Core and Visual Studio Tooling:

http://go.microsoft.com/fwlink/?LinkID=798306

Install Secret Manager:

https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets

Add your app_id and app_key to Secret Manager:

dotnet user-secrets set app_id [xxxxxx]

dotnet user-secrets set app_key [xxxxxx]

Install Json.Net from the Packager Manager Console:

PM> Install-Package Newtonsoft.Json 
