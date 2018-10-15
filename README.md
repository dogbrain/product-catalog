# Product Catalog

## Description
This is an ASP.NET Core 2.1 application. It makes use of the followimng tools:
* Vue
* Node package manager (npm)
* Typescript
* Webpack
* Bootstrap
* JQuery (not used atm)

I started with finding a base template for the project. I googled around a bit and found this guide https://www.dotnetcurry.com/aspnet/1383/modern-web-dev-aspnet-core-webpack-vuejs. 

## How to get started
* Run npm install
* Run npm install -g webpack
* webpack --config webpack.config.vendor.js
* Run in visual studio or with dotnet run

## Integration Testing
To start the integration testin please start the server with dotnet run from console and then run the tests.	

## Deployment Instructions for AWS Elastic beanstalk
* Run the create-aws-deployment.ps1 powershell script.
* Upload the created zip file to elastic beanstalk