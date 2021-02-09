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

**Camadas**

- Presentation (Apresentação).
- Application (Aplicação).
- Domain (Domínio).
- Infrastructure (Infraestrutura).


- Camada de Domínio