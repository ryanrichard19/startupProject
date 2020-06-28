# StartupProject
This is a startup project to use as as starting point for other projects

## Migration Scripts
```powershell
dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialModel --context appdbcontext -p ../StartupProject.Infrastructure/StartupProject.Infrastructure.csproj -s StartupProject.Web.csproj -o Data/Migrations
dotnet ef migrations add InitialIdentityModel --context appidentitydbcontext -p ../StartupProject.Infrastructure/StartupProject.Infrastructure.csproj -s StartupProject.Web.csproj -o Identity/Migrations
```

```powershell
dotnet ef database update -c appdbcontext -p ../StartupProject.Infrastructure/StartupProject.Infrastructure.csproj -s StartupProject.Web.csproj
dotnet ef database update -c appidentitydbcontext -p ../StartupProject.Infrastructure/StartupProject.Infrastructure.csproj -s StartupProject.Web.csproj
```
# Setting up github actions

## Publish
[Secrets setup Instructions](https://docs.microsoft.com/en-us/azure/app-service/deploy-github-actions)

