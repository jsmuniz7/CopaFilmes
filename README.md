# CopaFilmes
CopaFilmes é um projeto para demonstração de desenvolvimento de software com WebApi e SPA.
O projeto simula uma competição entre filmes, a serem selecionados pelo usuário e através de um algoritmo, realiza as partidas entre os filmes e decide o campeão e vice-campeão da competição

## Tecnologias

O projeto contido nesse repositório possui tanto os códigos para o frontend quanto para o backend.
A parte de frontend foi desenvolvida em Angular e pode ser acessada através da pasta [src/frontend]()
A Web Api para o backend foi desenvolvida em .NET Core 2.2 e pode ser acessada através da pasta [src/backend]()


This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 8.0.3.

## Frontend

O projeto de frontend foi gerado com [Angular CLI](https://github.com/angular/angular-cli) versão 8.0.3 com o Node .js na versão 10.16.0
Para rodar o projeto, é necessário tais versões instaladas

Para acesso da aplicação em um servidor de desenvolvimento, rode o comando `ng serve` e após compilação bem sucedida, navegue para `http://localhost:4200/`

Para buildar o projeto, rode o comando `ng build`. Os artefatos compilados estarão disponíveis na pasta `dist/`. Use a flag `--prod` para um build de produção.

## Backend
O projeto de backend foi desenvolvido com [.NET Core 2.2](https://dotnet.microsoft.com), logo é necessário o runtime equivalente ou superior instalado na máquina para rodar o projeto.

Para acesso da aplicação, rode o comando `dotnet run` na raiz da pasta da solution e  navegue para `http:\\localhost:5000`. A WebApi disponibiliza a interface do [Swagger](https://swagger.io/tools/swagger-ui/) para consulta e consumo dos endpoints

Para rodar os testes automatizados, rode o comando `dotnet test`


