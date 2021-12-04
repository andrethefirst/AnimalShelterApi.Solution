## Building an Animal Shelter Api

#### _Building an Animal Shelter Api_

#### By _**Andre Velasquez**_
## Description
This is a project that builds an API with C# using Pagination. It is an Animal Shelter APi to see Animals that are available. There is no UI so you can use Postman to see CRUD

## Technologies Used

* _C#_
* _MySQL_ 
* _Postman_
* _.NET 5 SDK_
* _ASP .NET CORE 5.0_
* _Entity Framework Core_
* _Git_
* _Pagination_

## Setup/Installation Requirements

1. Clone `https://github.com/andrethefirst/AnimalShelterApi.Solution` to your machine
2. Open terminal and navigate to the AnimalShelter directory and run 'dotnet restore'
3. Use Migrations to create database.
  -create appsettings.json file in AnimalShelter directory and add the code:
  ````
  {
    "ConnectionStrings":
    {
      "DefaultConnection": "Server=localhost;Port=3306;database={database_name};uid={Your_user_name};pwd={your_password};"
    }
  }
  ````
  -Enter your information for MySql in correct places

4. run dotnet run in AnimalShelter directory and use Postman to view data

## Known Bugs

* _No known Bugs_

## License

*GNU GENERAL PUBLIC LICENSE
                       Version 3, 29 June 2007

 Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.

 _{If you run into any problems, have any questions, or any ideas contact me!}_

 ## Contact Information

 _{email: andrethefirst21@gmail.com}_