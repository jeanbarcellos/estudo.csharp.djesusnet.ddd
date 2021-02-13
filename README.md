_Repositório apenas para estudo_

# Implementando na prática Rest API com conceitos de DDD + .NET CORE + SQL no Docker + IoC

Instrutor:

- [Danoeil Jesus](https://github.com/djesusnet)

Referências:

- https://medium.com/beelabacademy/implementando-na-pr%C3%A1tica-rest-api-com-conceitos-de-ddd-net-core-sql-no-docker-ioc-2cb3a2e7c649
- https://medium.com/beelabacademy/implementando-na-pr%C3%A1tica-rest-api-com-conceitos-de-ddd-net-2160291a44b7

<br>
<br>
<hr>

## Teórico

**01 - Camada de Apresentação**

A camada de apresentação que é responsável por abranger tudo o que diz respeito as interações com o cliente. Nela pode ser:

- Aplicação Desktop (WinForms).
- Aplicação Web (Angular, React, Vue).
- Aplicação Mobile (Android).
- Aplicação de serviço (WCF, Rest Api).

**02 - Camada de Aplicação**

A camada de aplicação que é responsável por realizar a(s) aplicação(s) se comunicar diretamente com o Domínio. Nela são implementados:

- Classes dos Serviços da aplicação.
- Interfaces (contratos).
- DataTransferObjects (DTO).
- AutoMapper

Na camada de aplicação não é implementada nenhuma regra de negócio, ela somente coordena a execução de uma tarefa e delega para os objetos de domínio na camada inferior

**03 - Domínio**

A camada de domínio que é responsável por ter um uma modelagem sólida e aqui que a mágica do DDD(Domain Drive Design) acontece. Nessa camada temos:

- Entidades.
- Interfaces (contratos) para Serviços e Repositórios.
- Classes dos Serviços do domínio.
- Validações (caso seja necessário).

**04 - Infraestrutura**

A camada de infraestrutura é responsável por dar o suporte as demais camadas. Que atualmente é dividida por duas camadas com seus respectivos conteúdos:

- Data:

  - Repositórios.
  - DataModel (Mapeamento).
  - Persistência de dados.

- CrossCutting: camada que atravessa todas as outras, portando possui referência de todas elas

  - IoC (Inversão de controle).

## Prático

- **Domain**:

  Domínio da aplicação:

  Diretórios:

  - **Entities**

  Sub:

  - **Domain.Core**

    Referências:

    - `Domain`

    Diretórios:

    - **Interfaces**

  - **Domain.Services**

    Referências:

    - `Domain.Core`

    Diretórios

    - **Services**

- **Application**:

  Responsável por ...

  Referências:

  - `Domain.Core`

  Pacotes:

  - `AutoMapper.Extensions.Microsoft.DependencyInjection`

  Diretórios:

  - **DTO:** Objeto de Transferência de Dados, é um padrão de projeto de software usado para transferir dados entre subsistemas de um software. DTOs são frequentemente usados em conjunção com objetos de acesso a dados para obter dados de um banco de dados.

  - **Interfaces**

  - **Mappings**

  - **Services**

- **Service (API)**

  Responsável por ...

  Referências:

  - `Application`
  - `Infrastructure.IoC`

  Pacotes:

  - `Autofac`
  - `AutoFac.Extensions.DependencyInjection`
  - `Microsoft.EntityFrameworkCore.Design`

  Diretórios:

  - Controllers

- **Infrastructure**:

  Responsável por ...

  - Infrastructure.**Data**:

    Responsável por ...

    Referências:

    - `Domain.Core`

    Pacotes:

    - `Npgsql.EntityFrameworkCore.PostgreSQL`
    - `Microsoft.EntityFrameworkCore.Design`

  - Infrastructure.**IoC**:

    Responsável por ...

    Referências:

    - `Application`
    - `Domain.Core`
    - `Infrastructure.Data`

    Pacotes:

    - `Autofac`

    Arquivos:

    - `Program.cs`

      Configurar o host, usando `UseServiceProviderFactory(new AutofacServiceProviderFactory())`.

      ```cs
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
      ```

      Resultado:

      ```cs
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
      ```

- **Presentation**

  Front-end React, Angular, etc ...

<br>
<br>
<hr>

### Criando as Migrations

Executar o comando para gerar as migrações:

```bash
# Se estiver dentro do diretório src/WebApi.Infrastructure.Data
dotnet ef --startup-project ../WebApi.Service.Api --project ./WebApi.Infrastructure.Data.csproj migrations add Initial

# Se estiver na raiz do projeto
dotnet ef --startup-project src/WebApi.Service.Api/ --project src/WebApi.Infrastructure.Data/WebApi.Infrastructure.Data.csproj  migrations add Initial
```

- Observe que no comando definimos o projeto startup como sendo o projeto `WebApi.Services.Api` que contém a string de conexão e o projeto `WebApi.Infrastructure.Data` onde temos as referências ao `EntityFramework`.
- ~~Tabmém foi preciso instalar o pacote `Microsoft.EntityFrameworkCore.Design` em `WebApi.Services.Api`~~

Executar o domando para aplicar as Migrações no banco de dados:

```bash
# Se estiver dentro do diretório src/WebApi.Infrastructure.Data
dotnet ef --startup-project ../WebApi.Service.Api --project ./WebApi.Infrastructure.Data.csproj database update

# Se estiver na raiz do projeto
dotnet ef --startup-project src/WebApi.Service.Api/ --project src/WebApi.Infrastructure.Data/WebApi.Infrastructure.Data.csproj database update
```

<br>
<br>
<hr>

### Executar o projeto

Estando no diretório raiz

```
dotnet watch -p src/WebApi.Service.Api/WebApi.Service.Api.csproj run
```
