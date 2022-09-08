## Criando o Projeto

* ```dotnet new sln --name solution_name```
* ```dotnet new webapi -o solution_name.template_project --no-https true```
* ```dotnet sln solution_name.sln add ./solution_name.template_project/solution_name.template_project.csproj```
* ```dotnet new gitignore```
* ```cd Catalog.WebApi```
* ```dotnet add package MongoDB.Driver --version 2.17.1```

## Executando o Projeto

* ```dotnet run --project solution_name.template_project```
* ```app.UseSwaggerUI(x => { x.SwaggerEndpoint("/swagger/v1/swagger.json", "V1"); x.RoutePrefix = ""; });```
  * modificação na classe **Program.cs** para redirecionar ao **swagger** acessando a url exposta na api