## Criando o Projeto

* ```dotnet new sln --name solution_name```
* ```dotnet new webapi -o solution_name.template_project --no-https true```
* ```dotnet sln solution_name.sln add ./solution_name.template_project/solution_name.template_project.csproj```
* ```dotnet new gitignore```
* ```cd Basket.WebApi```
* ```dotnet add package StackExchange.Redis```

## Executando o Projeto

* ```dotnet run --project solution_name.template_project```
* ```app.UseSwaggerUI(x => { x.SwaggerEndpoint("/swagger/v1/swagger.json", "V1"); x.RoutePrefix = ""; });```
  * modificação na classe **Program.cs** para redirecionar ao **swagger** acessando a url exposta na api

## Executando o Container do Redis

* ```docker run -d -p 6379:6379 redis```
  * ```docker container exec id_container sh```
    * ```redis-cli```
      * ```type key```
      * ```hgetall key```

## Packages Grpc Client

* ```dotnet add package Grpc.Net.Client```
* ```dotnet add package Google.Protobuf```
* ```dotnet add package Grpc.Tools```

## Build do Cenário com Docker-Compose

* ```docker network create backend```
* ```docker-compose build --no-cache```
* ```docker-compose up -d```
* ```docker-compose down --rmi all -v```