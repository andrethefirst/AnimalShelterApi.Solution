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

## API Endpoints
Once command `dotnet run` is run, use Postman to access the Api endpoints

 - **[READ]** -- to view ALL animals, send a `GET` request to `/api/animals`
 - **[CREATE]** -- to create a new animal available at the shelter, send a `POST` request to `/api/animals`
 - **[READ]** -- to view a specific animal given an id, send a `GET` request to `/api/animal/{id}`
    -the {id} should be replaced by the specific id of the animal, without the curly brackets
 - **[UPDATE]** -- to update/edit a specific animal's information, send a `PUT` request to `/api/animals/{id}`
 - **[DELETE]** -- to delete an animal entry, locate the animal id you want to delete. Then send a `DELETE` request to `/api/animals/{id}`

## Example

````
http://localhost:5001/api/animals?species=dog
````

## Pagination
After sending the inital `GET` request to `/api/animals`, the user can use `page` and `perPage` parameters to specify which page the user wants to view, and how many animals can be viewed.

To use view the API responses using pagination in Postman:
- select the `Params` tab
- add a `KEY` with the name `page`
  - for this `VALUE`, you can start at `0`
  - default with have `3` animals per page.
- if you want to edit how many animals to view per page, add a second `KEY` labeled `perPage`
  - for the `perPage` value, as long as the value is between 1 and the total number of animals available.
  - you can find the `total` amount of animals as the `total` property shown on the bottom of the page details in the API response. 

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