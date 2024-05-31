# ST10019838_PROG7311_POE
## WELCOME!
Welcome to my repository! This repo contains all of my solutions to the PROG67311 POE.

</br>

Notes:

> - Authentication for the app is handled by a third party named Auth0.
> - The database is populated through the migration, so ensure everything is right


</br>

# SUPER IMPORTANT: 
**DO NOT** forget to add your connection string to appsettings.json file under 'DbConnection'.

&nbsp;

# Credentials to Log in

For an **Employee**:
> Email: employee1234@gmail.com <br>
> Password: Password123# <br>
> Username: employee1

<br>

For a **Farmer**:
> Email: dave@gmail.com <br>
> Password: Password123# <br>
> Username: dave897


</br>

# Agri-Energy Connect

A digital ecosystem where farmers, green energy experts, and enthusiasts can collaborate, share 
resources, and innovate in the realms of sustainable agriculture and renewable energy

This application allows:
> - All Users to log in to thier accounts

**Employees** to:
> - Add Farmers
> - View Farmers and their Products

**Farmers** to:
> - Add Products to their profile
> - View thier products they made



</br>

# Project Set-Up
## Prequisites
- Visual Studio 2022, prefferably the latest verion.
- .Net 8.0 Installed
- SQL Server

</br>

## Installation

#### Downloading:
1. Click the the green code button in the repository
2. Download a zip file of the repository
3. Navigate to the downloaded file
4. Extract the zip file
5. Open the extracted folder in Visual Studio

&nbsp;

#### Cloning:
(Ignore step 1 if alreay in the main repository)
1. Navigate to the main repository (Click on the link provided in the readme)
2. Click the the green code button in the repository
3. Click the "Open with Visual Studio" option
4. Accept the pop up alert
5. Select your repository path
6. Click "clone" at the bottom right of the window

</br>

## Setting up the database
#### Through Visual Studio:
1. Get the connection string of the database you want the content to be stored in
2. Navigate to the "ST10019838_DamianDare_PROG67311_POE" folder in the file explorer
3. Open the "ST10019838_DamianDare_PROG7311_POE.sln" solution file
4. Find and Open the "appsettings.json" file, if it already isn't open
7. Under 'DbConnection', place YOUR database connection string
9. Open the Package Manager Console
10. Type in the command "update-database"

If an error occurs at step 10, try:
1. Checking your connection string
2. Deleting the "Migrations" folder
3. Open the Package Manager Console
4. Create a new migration by typing in the command "add-migration newMigration"
5. After the migration has been made, navigate to that migration file in the "Migrations" folder
7. Go back to the Package Manager Console
8. Type in the command "update-database -verbose"
   
(Note: this above method will remove the initial data, so dont forget to copy the
SQL in the 'UP' method in the ** Existing ** migration before deleting it!)


</br>

## How to run (After Setting up the database)
#### Through Visual Studio:
1. Navigate to the "ST10019838_DamianDare_PROG67311_Code" folder in the solution explorer, and open it if it already isn't open
2. Open the solution file
4. Click the start button in the tool bar
   

</br>

# Packages Installed
### For the ApiClassLibrary:
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SQLServer
- Carter
- Auth0


</br>

# References

Microsoft Docs: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/?view=netdesktop-7.0

Foreign Keys and Relationships For Entity Framework: https://learn.microsoft.com/en-us/ef/core/modeling/relationships

tutorialspoint: https://www.tutorialspoint.com/wpf/index.htm

stack overflow: https://stackoverflow.com/

Minimal Api Creation: https://www.youtube.com/watch?v=gsAuFIhXz3g

MudBlazor: https://mudblazor.com/

Blazor School: https://blazorschool.com/

Blazor: https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor
