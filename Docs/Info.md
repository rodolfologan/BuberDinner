# Dotnet commands

dotnet new sln -0 BuberDinner

dotnet new webapi -o BuberDinner.Api
dotnet new classlib -o BuberDinner.Contracts
dotnet new classlib -o BuberDinner.Infrastructe
dotnet new classlib -o BuberDinner.Aplication
dotnet new classlib -o BuberDinner.Domain

dotnet build

more .\BubeerDinner.sln

// will recursively add all projects to sln
dotnet sln add (ls -r **\*.csproj)

// the start (*) +<project sufix> and hit tab
dotnet add *Api

dotnet add .\BuberDinner.Api\ reference .\BuberDinner.Contracts\ .\BuberDinner.Application\
dotnet add .\BuberDinner.Infrastructure\ reference .\BuberDinner.Application\
dotnet add .\BuberDinner.Application\ reference .\BuberDinner.Domain\
dotnet add .\BuberDinner.Api\ reference .\BuberDinner.Infrastructure\

dotnet build

// visual studio extensions
Rest Client

dotnet run --project .\BuberDinner.Api\

// Add nuget package
dotnet add .\BuberDinner.Application\ package Microsoft.Extensions.DependencyInjection.Abstractions