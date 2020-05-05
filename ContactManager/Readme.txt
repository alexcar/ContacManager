Instalando o Entityframework Core 3.1
=====================================

Instala o provider do Sql Server
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.0

OU

Instalar o provider do SQlite
> dotnet add package Microsoft.EntityFrameworkCore.Sqlite

Instalar o dotnet ef comandos porque não é mais incluído no .NET Core SDK desde a versão 3
> dotnet tool install --global dotnet-ef --version 3.1.0

Criar o modelo
==============
Defina uma classe de contexto [Models.AppDbContext.cs] e a classe de entidade [Models.Customer.cs] que 
compõem o modelo.

Criar o banco de dados
======================
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update


Criar, ler, atualizar e excluir
===============================


Comandos Git
============
git init
git add .
git commit -m "first commit"
git remote add origin https://github.com/alexcar/ContacManager.git
git push -u origin master
git reset <filename> # para remover um arquivo após o comando git add <filename>
git reset # para remover todos os arquivos do comando git add .
