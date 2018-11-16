# CsharpFinal11162018
Code Louisville Final Project Fall 2018 C# Csharp

I found datasets for Food Inspections for the State of Kentucky online https://catalog.data.gov .  From a small subset of this dataset  I created a very basic CRUD app for web browser that displays data, enables the user to add, delete and edit.

Requires the following packages:

- EntityFramework.6.2.0
- Microsoft.AspNet.Mvc.5.2.6
- Microsoft.AspNet.Razor.3.2.3
- Microsoft.AspNet.WebPages.3.2.3
- Microsoft.CodeDom.Providers.DotNetCompilerPlatform.2.0.0
- Microsoft.Web.Infrastructure.1.0.0.0

Clone Repository in Visual studio.  May need to connect to the Data Source InspectionAppCTXT by right clicking and "refreshing" InspectionAppCTXT through the Server Explorer. Press F5 to build.  This will open web browser for application to run.

Application opens with index page.
Click on Locations at top of page to experience CRUD: Create (Add Loaction Button), Read (Detail link), Update (Edit link), Delete (Delete link).

Future commits would include:
- search function
- constraints and formatting checks on textboxes
- replace some textboxes with pre-populated Dropdowns
- LocationView as a grid format
