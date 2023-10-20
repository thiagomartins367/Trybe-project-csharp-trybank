# Trybank

Boas-vindas ao repositório do projeto `Trybank`

Nesse projeto foi desenvolvido uma aplicação para controlar contas bancárias bem como realizar as suas operações básicas de checar um saldo, depositar, sacar e transferir dinheiro. Além disso, é possível cadastrar novas contas, efetuar login e logout no sistema.

Desenvolvido durante o período de **Aceleração C#** da Trybe 🚀

Tem por objetivo a avaliação e prática dos conhecimentos adquiridos durante a aceleração, visando o cumprimento do requisitos solicitados!

## Instalação e Uso 🖥️
⚠️ É necessário ter instalado o [.NET Framework](https://dotnet.microsoft.com/pt-br) (Windows) ou [.NET Core](https://dotnet.microsoft.com/pt-br/) (Linux/ Mac) em sua máquina para executar o sistema.

**Na raiz do projeto execute os comandos abaixo no seu terminal:**

1. Instale as dependências
```
dotnet restore ./src
```

2. Execute a aplicação
```
dotnet run --project ./src/trybank/trybank.csproj
```

## Desenvolvimento 🧑‍💻
⚠️ É necessário ter o [Git](https://git-scm.com) instalado em sua máquina para o controle de versão do sistema.

Certifique-se de ter instalado o [.NET Framework](https://dotnet.microsoft.com/pt-br) (Windows) ou [.NET Core](https://dotnet.microsoft.com/pt-br/) (Linux/ Mac) em sua máquina para o desenvolvimento de novas funcionalidades ou refatorações de código.

Utilize os scripts do arquivo ```Makefile``` na raiz do projeto para aumentar a agilidade durante o desenvolvimento.

**Na raiz do projeto execute os comandos abaixo no seu terminal:**
1. Instale as dependências
```
dotnet restore ./src
```

2. Crie e entre em uma nova *branch* de desenvolvimento
```
git checkout -b nome-da-branch
```

3. Execute os testes
```
dotnet test ./src/src.sln
```
Para adicionar as alterações da nova branch de desenvolvimento na branch principal ```main``` é nescessário criar um *Pull Request* neste repositório.

Alterações diretas na branch ```main``` estão bloqueadas.

## Contribuidores

- [THIAGO MARTINS](https://github.com/thiagomartins367) - criador e mantenedor
