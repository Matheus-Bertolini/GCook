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
git clone https://github.com/Matheus-Bertolini/GCook.git<br></br>
cd seu_repositorio<br></br>
Restaure os pacotes:<br></br>

dotnet restore<br></br>
Execute as migrações do banco de dados:<br></br>

dotnet ef database update<br></br>
Compile e execute o projeto:<br></br>

dotnet watch run<br></br>
O projeto estará disponível em https://localhost:5001 ou http://localhost:5000.

Desenvolvimento
Durante o desenvolvimento, use o Visual Studio Code ou o terminal para compilar e executar a aplicação. Verifique se o servidor MySQL está ativo no XAMPP.

Tecnologias
ASP.NET Core MVC 8
MySQL
Entity Framework Core
XAMPP
