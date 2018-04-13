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

## Objetivo ##
* Desenvolver uma página ou sistema que capte o nome, E-mail e salário do funcionário e em seguida execute a seguinte regra:
- Para salários de R$ 3.000,00 à R$ 5.000,00 teremos 10% de impostos
- Para salários de R$ 5.000,00 à R$ 7.000,00 teremos 15% de impostos
- Para salários acima R$ 7.000,00 teremos 25% de impostos
- Salários abaixo de R$ 3.000,00 serão isentos
* Após a captação e aplicação dos impostos, deve ser exibido na tela o seguinte:
- Nome do funcionário
- Valor líquido do salário
- Faixa de imposto aplicada
- Valor final com dedução do imposto

### Especificações técnicas
A página criada deve utilizar-se das seguintes tecnologias:
- ASP.NET Core 2.0 ou superior
- Angular 4 ou Superior

#### Observações
Não foi mensionado sobre banco de dados e padrões exigidos.
Portanto, devido ao tamanho do projeto optou-se:
* SQLite (Caso necessário, fácil está mudar)
* API em um único projeto, simples (se aumentar o projeto, é simples segregar mais)

### Imagens
Inicio
![alt text](http://buzatto.com/employeeapp/TelaInicial.png)

Cadastro
![alt text](http://buzatto.com/employeeapp/Cadastro.png)

Objetivo
![alt text](http://buzatto.com/employeeapp/Objetivo.png)
