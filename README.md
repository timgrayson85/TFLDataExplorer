# TFLDataExplorer
A simple C# MVC Web Application for viewing data from the Transport for London Unified API.

Pre-requisites:

1. Install Visual Studio 2015:

https://www.visualstudio.com/en-us/visual-studio-homepage-vs.aspx

2. Install .net Core and Visual Studio Tooling:

http://go.microsoft.com/fwlink/?LinkID=798306

3. Install Secret Manager:

https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets

4. Add your app_id and app_key to Secret Manager:

dotnet user-secrets set app_id [xxxxxx]

dotnet user-secrets set app_key [xxxxxx]

5. Install Json.Net from the Packager Manager Console:

 PM> Install-Package Newtonsoft.Json 
