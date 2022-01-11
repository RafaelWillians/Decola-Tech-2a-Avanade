# Criando o ambiente de desenvolvimento

## Instalando o .NET

[Download .NET (Linux, macOS, and Windows)](https://dotnet.microsoft.com/download)

[.NET Core 3.1 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)

[Todas versões de .NET](https://dotnet.microsoft.com/en-us/download/dotnet)

## Diferenças entre .NET Framework, Core e .NET 5

.NET Framework é Windows apenas. Lançado em 2002, com o foco em Windows e Web.

O .NET Core foi lançado em 2016, com intuito de atender tanto Windows quanto Linux, macOS, etc. Porém é distinto do .NET Framework. 

Então surgiu o .NET Standard, que é um conjunto de libraries de classe padrões para integrar o Framework com o Core.

.NET 5 foi lançado em 2020 e trouxe tanto melhorias, quanto uma unificação do Framework com o Core. 

![](C:\Users\PC\Documents\Workspace\Decola-Tech-2a-Avanade\Criando%20o%20ambiente%20de%20desenvolvimento\dotnet5.png)

## Framework e Runtime

Framework é como uma caixa de ferramentas. Há vários recursos prontos, que você pode utilizar ao desenvolver um projeto de software.

Runtime é um recurso que transforma um bloco de código em linguagem de máquina. São como um manual de instruções de uma mesa, por exemplo. No Runtime são definidas as instruções que serão executadas enquanto o programa de computador está executando. Em vez de você informar linha por linha exatamente, em linguagem de máquina, o que o seu programa irá fazer, é o Runtime que irá definir esses detalhes, até para facilitar para o desenvolvedor escrever o código e este ficar mais fácil de ler e trabalhar.  

## CLI do .NET

CLI = Command Line Interface ou interface de linha de comando

É como o prompt de comando do Windows, aliás, este mesmo pode até ser usado para  rodar os comandos do .NET.

Exemplos de comandos:

| Comando                      | Descrição                                                                                                                                                             |
| ---------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| dotnet --version             | Retorna a versão instalada do .NET.                                                                                                                                   |
| dotnet --help                | Mosta a lista com todos os comandos disponíveis.                                                                                                                      |
| dotnet --info                | Retorna um bloco de informações, sobre os SDKs instalados, runtimes instalados, sobre o ambiente de runtime, etc.                                                     |
| dotnet new                   | Serve para criar um projeto do .NET. Porém é necessário informar qual o tipo de projeto. Digitando apenas isso, retorna a lista com os tipos de projetos disponíveis. |
| dotnet new --list            | Retorna uma lista completa, com todos os tipos de projetos disponíveis.                                                                                               |
| dotnet new --list --tag web  | Retorna uma lista com todo os tipos de projeto web disponíveis.                                                                                                       |
| dotnet new console -o MeuApp | Serve para criar um novo projeto do tipo Console, com o nome "MeuApp", no diretório em que o terminal está aberto.                                                    |
