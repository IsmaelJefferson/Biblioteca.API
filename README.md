
# Biblioteca.API

Este projeto é uma Web API desenvolvida em .NET, destinada ao gerenciamento de uma biblioteca. A API oferece funcionalidades para o cadastro, edição, deleção e busca de livros, além de implementar autenticação via JWT.

## Funcionalidades

- **Cadastro de Livros**: Permite registrar novos livros no sistema.
- **Edição de Livros**: Modifica os dados dos livros cadastrados.
- **Deleção de Livros**: Exclui livros do sistema.
- **Busca de Livros**: Permite realizar buscas de livros com base em critérios específicos.
- **Autenticação JWT**: Utiliza JSON Web Tokens (JWT) para garantir a segurança e o acesso autorizado às funcionalidades da API.

## Tecnologias Utilizadas

- **.NET 8**: Framework para desenvolvimento da API.
- **Entity Framework Core**: Para gerenciamento do banco de dados.
- **SQL Server**: Banco de dados utilizado para armazenar as informações da biblioteca.
- **JWT (JSON Web Tokens)**: Para autenticação e autorização dos usuários.

## Estrutura do Projeto

- **Controllers**: Contém os controladores da API responsáveis pelas rotas e operações de CRUD.
- **Models**: Define as entidades do sistema, como `Book` e `User`.
- **Services**: Contém a lógica de negócios da aplicação.
- **Data**: Gerencia o contexto de dados com o Entity Framework.
- **Authentication**: Implementação da autenticação via JWT.

## Instalação

Para rodar este projeto em sua máquina local, siga as instruções abaixo:

### 1. Clone o repositório

```bash
git clone https://github.com/IsmaelJefferson/Biblioteca.API.git
```

### 2. Navegue até a pasta do projeto

```bash
cd Biblioteca.API
```

### 3. Restaure os pacotes NuGet

```bash
dotnet restore
```

### 4. Configure o banco de dados

Certifique-se de que o banco de dados SQL Server esteja configurado corretamente e atualize as credenciais no arquivo `appsettings.json`.

### 5. Execute o projeto

```bash
dotnet run
```

A API estará disponível em `http://localhost:5000` por padrão.

## Endpoints

A API oferece os seguintes endpoints:

- **POST /api/books**: Cria um novo livro.
- **GET /api/books**: Lista todos os livros.
- **GET /api/books/{id}**: Obtém detalhes de um livro específico.
- **PUT /api/books/{id}**: Atualiza um livro específico.
- **DELETE /api/books/{id}**: Deleta um livro específico.

## Autenticação

Para acessar os endpoints protegidos, é necessário autenticar-se via JWT. Use o endpoint `/api/auth/login` para obter o token JWT.

Exemplo de login:

```bash
POST /api/auth/login
Content-Type: application/json
{
  "username": "usuario",
  "password": "senha"
}
```

O token JWT será retornado na resposta e deverá ser incluído no cabeçalho `Authorization` das requisições subsequentes.

## Contribuições

Contribuições são bem-vindas! Se você deseja melhorar o projeto, sinta-se à vontade para abrir um pull request.

1. Faça um fork deste repositório.
2. Crie uma branch com a sua feature: `git checkout -b minha-feature`.
3. Comite suas mudanças: `git commit -am 'Adiciona nova feature'`.
4. Envie para o repositório remoto: `git push origin minha-feature`.
5. Abra um pull request.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

Desenvolvido por [Ismael Jefferson](https://github.com/IsmaelJefferson).
