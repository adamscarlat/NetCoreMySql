# NetCoreMySql
Scaffolding for a Web Api Application Connected to a MySql database. 

## Prerequisites

* Dotnet Core 3.1 SDK
* Docker
* VS Code (optional)

## Preparing and Starting the Database

* First fire up the database as a container:
    ```
    docker-compose up -d db 
    ```
    **The database server might need a minute to start up**
    
* If this is the first time you are running the project or if you have made database changes you should run migrations and update your database:
    ```
    cd api
    dotnet restore
    dotnet ef migrations add initial_migration
    dotnet ef database update
    ```

At this point the database should be up and running with the project schema installed. You can test it by connecting to it from any MySql UI tool (e.g. MySql WorkBench) with the following connection details:

* Host: `localhost`
* Port: `3306`
* User: `weather-api-user`
* Password: `password`

## Running the API in Debug Mode

When running in debug mode the database runs as a container and the application runs as a process started by your IDE or terminal. The application will connect to the database using the host `localhost`. 

When running in debug mode the application starts in `Development` mode. This means that it will use the development configurations found in the file `api\appsettings.Development.json`.

#### From VS Code

* `Run --> Start Debugging`

#### From the command line

```
cd api
dotnet run
```

## Running the API as a Container

Before starting the API as a container you have to build the Docker image for the API. You can find the details for how the image gets built in the `api/Dockerfile` file.

When running the API as a container it will connect to the database using the host `db` (name of the database service in the `docker-compose.yml` file).

When running as a container the application starts in `Production` mode. This means that it will use the production configurations found in the file `api\appsettings.json`.

Run the following commands in the root level of the project folder:

* Build the API image:
    ```
    docker-compose build api
    ```
* Run the application:
    ```
    docker-compose up -d
    ```

## API Endpoints

The application is served on `http://localhost:5000`. Below are the endpoints:

* `/WeatherForcast`
    - `GET` : Get all weather datapoints.

