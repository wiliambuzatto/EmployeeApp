# EmployeeApp
### Sistema SPA Angular 5 com Api Asp.Net Core 2.0

## Nota
Este repositório contém 2 projetos distintos:
* Asp.Net Core 2 (API Asp.Net Core)
* Angular 2      (SPA Angular 5+)

## Para funcionar corretamente
Ao realizar o download é necessário:

**Restaurar os pacotes da API** (dentro do projeto EmployeeApp.API): 
```bash
dotnet restore
```
**Restaurar node_modules** (dentro do projeto EmployeeApp.SPA): 
```bash
npm install
```

**Execute primeiramente a API**
```bash
dotnet run
```
**Execute então o angular**
```bash
ng serve
```

