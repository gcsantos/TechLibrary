# TechLibrary

## Sobre o Projeto
O **TechLibrary** é um sistema desenvolvido em C# para gerenciar uma biblioteca técnica. Ele fornece uma API para manipulação de livros, usuários e outras entidades relacionadas. O projeto segue uma arquitetura modular, permitindo escalabilidade e manutenção simplificada.

Este projeto foi baseado em um evento da **Rocketseat**, onde foram abordadas boas práticas de desenvolvimento e arquitetura de software.

## Estrutura do Projeto
O repositório está organizado nos seguintes módulos:

- **TechLibrary.Api**: Contém a implementação da API RESTful.
- **TechLibrary.Communication**: Responsável pela comunicação entre os componentes do sistema.
- **TechLibrary.Exception**: Gerenciamento de exceções e erros no sistema.
- **TechLibraryDb.db**: Arquivo do banco de dados utilizado no projeto.

## Tecnologias Utilizadas
- **C#**
- **ASP.NET Core**
- **Entity Framework Core**
- **SQLite**

## Configuração e Execução
### 1. Clonar o Repositório
```sh
git clone https://github.com/gcsantos/TechLibrary.git
cd TechLibrary
```

### 2. Configurar o Banco de Dados
Certifique-se de que o arquivo `TechLibraryDb.db` esteja configurado corretamente. Caso necessário, rode as migrações do Entity Framework:
```sh
dotnet ef database update
```

### 3. Executar o Projeto
```sh
dotnet run --project TechLibrary.Api
```
A API estará disponível em: `http://localhost:5000`

## Contribuição
Sinta-se à vontade para contribuir com melhorias. Para isso:
1. Faça um **fork** do repositório.
2. Crie uma branch para sua feature: `git checkout -b minha-feature`
3. Faça o commit das suas alterações: `git commit -m 'Minha nova feature'`
4. Faça o push da sua branch: `git push origin minha-feature`
5. Abra um **Pull Request**.

## Licença
Este projeto está sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---
**Desenvolvido por [Guilherme Cintra Santos](https://github.com/gcsantos)**

