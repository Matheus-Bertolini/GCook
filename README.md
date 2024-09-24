#Projeto MVC com .NET 8
------------------------
*Este repositório contém uma aplicação MVC desenvolvida com .NET 8, utilizando MySQL como banco de dados, configurado via XAMPP. Siga as instruções abaixo para configurar e executar o projeto.

#Requisitos
-----------
--Certifique-se de ter instalado:

-Visual Studio Code<br>
-.NET SDK 8.0
-XAMPP (MySQL)</br>
-MySQL Workbench (opcional)<br></br>
*Configuração<br></br>
Inicie o XAMPP e execute o serviço MySQL.

#Crie a conexão "gcook" e lembre de mudar a senha de acordo com seu banco!

#Projeto<br></br>
Clone o repositório:

Copiar código
git clone https://github.com/seu_usuario/seu_repositorio.git
cd seu_repositorio
Restaure os pacotes:

bash
Copiar código
dotnet restore
Execute as migrações do banco de dados:

bash
Copiar código
dotnet ef database update
Compile e execute o projeto:

bash
Copiar código
dotnet run
O projeto estará disponível em https://localhost:5001 ou http://localhost:5000.

Desenvolvimento
Durante o desenvolvimento, use o Visual Studio ou o terminal para compilar e executar a aplicação. Verifique se o servidor MySQL está ativo no XAMPP.

Tecnologias
ASP.NET Core MVC 8
MySQL
Entity Framework Core
XAMPP
