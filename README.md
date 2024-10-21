UserRandomAPI é uma API desenvolvida para gerar dados de usuário aleatórios, facilitando o processo de desenvolvimento e teste de aplicações. Este projeto utiliza .NET 8 para criar uma API robusta e eficiente, ideal para desenvolvedores que precisam de dados fictícios para autenticação, perfis de usuário, entre outras funcionalidades.

Funcionalidades
Importação de Usuários: Permite a importação de uma quantidade específica de usuários.

Listagem de Usuários: Recupera todos os usuários com paginação, otimizando o desempenho.

Remoção de Usuários: Remove usuários pelo ID, garantindo flexibilidade na gestão de dados.

Tecnologias Utilizadas
.NET 8: Framework principal para desenvolvimento da API.

Entity Framework Core: Para gerenciamento de dados.

Swagger: Para documentação interativa da API.

Postman/Insomnia: Para testes de API.

Como Usar
Clone o repositório:

sh

Copiar
git clone https://github.com/vtoum/UserRandomAPI.git
Configuração: Configure o ambiente de desenvolvimento conforme as instruções no README.

Executar a API: Utilize dotnet run para iniciar o servidor e acessar a documentação interativa em /swagger.

Fazer Requisições: Utilize ferramentas como Postman ou Insomnia para fazer requisições à API e obter dados de usuário.

Estrutura do Projeto
Controllers: Contém controladores responsáveis por gerenciar as requisições HTTP.

DAO (Data Access Object): Contém classes para acesso aos dados.

Models: Define as entidades e modelos de dados.

Services: Implementa a lógica de negócios.

Migrations: Gerencia migrações do banco de dados.

## Docker Hub

docker pull vtn900/userrandomapi:latest
