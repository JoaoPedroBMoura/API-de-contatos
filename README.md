# API-de-contatos
An API designed to allow CRUD to be performed on a contact list

> This API was built using .NET version 6.0.428 and has a global.json file that configured the creation of this environment.

> This API has a default connection string of Sql Server, which was the DB used for local testing. Make whatever changes to the database you want, however, the string name is being accessed in Program.cs

> Swagger was used to interact with this application. It automatically opens in the .NET version of this API when we use the `dotnet watch run` command in the power shell terminal.
    ![Imagem do Swagger](./img/photo%20from%20APi.png)

>To use this API, simply download this repository and have it on your machine:
    - version 6.0 of .NET on the machine
    - Entity Framework version 6
    - package EntityFrameworkCore.Design version 6 
    - package EntityFrameworkCore.SqlServer version 6
        - They were used to make the Migrations