```sh

#create a solution
dotnet new sln --name SolutionName

#create a console project
#! --use-program-main param to use old style
dotnet new console -o ProjectName

#add project to solution
dotnet sln SolutionName.sln add ./ProjectName

#add a project reference
dotnet add ./AccessModifiersDemo reference ./AccessModifiers
```