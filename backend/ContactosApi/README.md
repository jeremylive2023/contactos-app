# Proyecto Node.js con dotNet 8 & Angular
## Instrucciones para realizar la migracion con exito

Primero debera crear una base de datos en PostgreSQL con el programa PgAdmin 4 en Windows. La base de datos se debe llamar "contactos".

## Ejecuta las migraciones de la base de datos:

Los comando para llevar acabo la migracion:
cd backend/ContactosApi
dotnet ef migrations add InitialCreate
dotnet ef database update

## Crear usuario que se usara en el login

Luego de haber creado la base de datos y hecho la migracion, es necesario crear un usuario en la tabla Users. Estos datos de usuario y contrana van hacer usados para realizar con exito el login obteniendo el acceso al sistema por medio de JWT Bearer token de dotNet 8 implemntado en Node.js


Puedes crear el usuario ejecutando esta consultat de SQL:

INSERT INTO public."Users"(
	"Id", "Username", "PasswordHash")
	VALUES (1, "test", "test");

## Configurar el backend:
cd backend
dotnet new webapi -n ContactosApi
cd ContactosApi
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer

## Configurar el frontend:
cd ../../frontend
ng new contactos-app --routing --style=scss
cd contactos-app
ng add @angular/material

## Nota
Estas dos configuraciones no son necesarias realmente si se clona el git. Ya que va a requerir nada mas el comando:
npm install

## Inicia el backend:
dotnet run

## Inicia el frontend:
cd ../../frontend/contactos-app
ng serve


# ContactosApp

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 18.1.3.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.
