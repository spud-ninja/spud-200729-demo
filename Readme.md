# Steps

## Preperation


### Structure 
```
mkdir BlazorDemo
cd BlazorDemo

```
### Project Setup
```
dotnet new gitignore
dotnet new globaljson --sdk-version 3.1.302
dotnet new sln -n BlazorEverywhere
dotnet new blazorserver -n BlazorHostServer
dotnet new blazorwasm -n BlazorHostClient
dotnet new blazorhybrid -n BlazorHostXamarin -p:Cr false -C false
dotnet new razorclasslib -n BlazorApplication
```
### Solution Setup
```
dotnet sln add BlazorApplication
dotnet sln add BlazorHostServer
dotnet sln add BlazorHostClient
dotnet sln add BlazorHostXamarin
dotnet sln add BlazorHostXamarin\BlazorHostXamarin.Windows\
```
- dotnet sln add BlazorHostXamarin\BlazorHostXamarin.Android\
  - This does not seem to work, project needed to be added manually in VS?
```
Open BlazorEverywhere.sln
Add  BlazorHostXamarin\BlazorHostXamarin.Android\ project
```
Begin Demo Reconstruction
