# Product Catalog

## Description
This is an ASP.NET Core 2.1 application. It makes use of the followimng tools:
* Vue
* Node package manager (npm)
* Typescript
* Webpack
* Bootstrap
* JQuery (not used atm)

I started with finding a base template for the project. I googled around a bit and found this guide https://github.com/vhanla/vuets. 

## How to get started
* Run dotnet tool install -g dotnet-aspnet-codegenerator
* Run dotnet restore
* Run npm install

## Integration Testing
To start the integration testin please start the server with dotnet run from console.
Update the BaseUrl in product-catalog.IntegrationTests.IndexPage.cs
Run the tests

## Deployment Instructions for AWS Elastic beanstalk
Deployment not working yet. But either something like this or with the help of docker
* ~~Run the create-aws-deployment.ps1 powershell script.~~
* ~~Upload the created zip file to elastic beanstalk~~