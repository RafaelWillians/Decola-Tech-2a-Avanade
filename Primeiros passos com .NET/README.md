# Primeiros passos com .NET

## Passado, presente e futuro do .NET

Anos 70: Microsoft criou a linguagem de programação Basic.

Anos 80: é lançado o DOS, que é usado como OS padrão para os computadores IBM. 

Final anos 90 (1997): Microsoft tentou consolidar ferramentas de desenvolvimento com o Visual Studio 97 (Visual Basic 5, Visual FoxPro 5, C++ 5, J++).

1998: lançado Visual Studio 6, com as ferramentas Visual Basic 6, Visual FoxPro 6, C++ 6 e J++ 6.

1999: Scott Guthrie criou ASP+, ferramenta web com Java (depois chamado de ASP Next e depois ASPX). Nesse mesmo ano, Jason Zander ajudou a criar um common runtime para VB e C++ (CLR - Common Language Runtime).

Ainda nesse ano, a Sun Microsystems fez um acordo para a Microsoft não mexer mais com Java e então, Anders Hejlsberg começou a trabalhar no C#.

2000: é lançado o .NET 1.0, inicialmente com nome Next Generation Windows Services (NGWS).

2001: Miguel de Icaza começa a desenvolver o projeto Mono, uma reimplementação black box do .NET, sendo open source e multiplataforma. Ele NÃO trabalhava na Microsoft nesse momento.

2002: lançado Visual Studio .NET com C# 1.0, conhecido como 22 linguagens, 1 plataforma (C#.net, C++.net, VB.net, J#.net, etc).

2003: lançamento do .NET 1.1 com o Visual Studio 2003. Trabalham nas melhorias na CLR para lançar a CLR 2.

2005: lançamento do .NET 2.0 com C# 2.0 no Visual Studio 2005. Microsoft começa a atingir o objetivo inicial, além de evoluir na web.

2007-2008: lançamento do .NET 3.5 com C# 3.0 no Visual Studio 2008, com Silverlight, WPF e WCF. Microsoft contrata time voltado para open source, para criar o ASP.NET MVC. Inicia-se ideia do Windows Azure.

2010: lançamento do .NET 4.0, com C# 4.0 no Visual Studio 2010, também com F#. Além do lançamento do Windows Azure. Anders Hejlsberg começa a trabalhar no Typescript.

2011: Miguel de Icaza inicia o Xamarin. Começaram a criar em C# aplicativos que rodam em Android e iOS.

2012: .NET 4.5, com C# 5.0 no Visual Studio 2012. Lançamento também do Typescript.

2013: .NET 4.5.1 no Visual Studio 2013. Início do Roslyn, novo compilador para C# e VB.NET (este compilador foi desenvolvido em C# mesmo).

Microsoft continua atuando na frente JS e aumenta o uso de ferramentas open source ao ambiente Microsoft.

Até agora, o ASP.NET sendo mais consolidado com MVC, Web API e SignalR. Ainda assim, era tudo muito focado no Windows.

2014: Satya Nadella se torna CEO e direciona o foco da empresa para cloud. Criada a .NET Foundation, para gestão de projetos open source.

Windows Azure se torna Microsoft Azure. Introduzido conceito do ASP.NET vNext, depois chamado de ASP.NET Core.

![](estrutura-aspnet-vnext.png)

2015: .NET 4.6 cp, C# 6.0 no VS 2015 e Visual Studio Code. O Code é open source e multiplataforma.

2016: Microsoft adquire a Xamarin e adiciona o produto como parte da stack .NET e projetos open source. Lançamento do Visual Studio for Mac.

Lançamento também do .NET Core 1.0, totalmente nova, open source e multiplataforma.

2017: Lançamento do .NET Framework 4.7 com C# 7.0 no VS 2017. Lançamento do .NET Core 2.0 com C# 7.0 no VS 2017, Visual Studio Code ou Visual Studio for Mac 2017.

2019: .NET Framework 4.8 com C# 7.3 no VS 2019 / .NET Core 3.0 com C# 8.0 no VS 2019, VS Code ou VS for Mac 2019.

2020: .NET Framework está pronto na versão 4.8, deixando de ser evoluído - junto com WCF e ASP.NET Webforms.

Agora só existe .NET 5, não mais .NET Framework.

.NET Framework é coisa do passado.

## O que é, como e onde usar .NET?

O .NET é uma infraestrutura para desenvolvimento de softwares, criada pela Microsoft. Uma aplicação .NET é desenvolvida usando uma das seguintes tecnologias:  .NET Core, .NET Framework, Mono ou UWP (Universal Windows Platform).

Ele serve para que múltiplas plataformas e múltiplas linguagens de programação podem usar toda uma gama de recursos em comum, para que possam ter as mesmas funcionalidades independente da plataforma que a aplicação será desenvolvida ou executada.

O conceito novo do .NET é ter o .NET Framework, .NET Core e Xamarin com suas distinções, porém as três compartilhando recursos através do .NET Standard Library, ou no slide mesmo, "uma única biblioteca para governar todos eles". E a partir dessa library unificada, então são utilizados os devidos compiladores, componentes de runtime e linguagens intermediárias ou de máquina.

![](C:\Users\PC\Documents\Workspace\Decola-Tech-2a-Avanade\Primeiros%20passos%20com%20.NET\dot-net.png)

Cada implementação abaixo inclui um ou mais .NET Runtimes (ambientes de execução):

- .NET Core: CoreCLR e CoreRT

- .NET Framework: CLR

- Mono: Mono Runtime

- UWP: .NET Native

Atualmente a Microsoft desenvolve e suporta 3 linguagens para .NET: C#, F# e VB.

## Preparando o ambiente

Instalação do [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/) e [Visual Studio Code](https://code.visualstudio.com/) 



## Conhecendo a CLI do .NET

Executando "dotnet --help" no prompt dará uma lista com vários comandos possíveis do .NET.

Exemplos de comandos:

| Comando            | Ação                                                                                                             | Exemplo de uso                          |                                                               |
| ------------------ | ---------------------------------------------------------------------------------------------------------------- | --------------------------------------- | ------------------------------------------------------------- |
| dotnet --version   | Traz a versão do .NET Instalado.                                                                                 |                                         |                                                               |
| dotnet --info      | Traz a lista de todos os recursos instalados do .NET.                                                            |                                         |                                                               |
| dotnet new console | Criar projeto de aplicação console na pasta atual.                                                               | dotnet new console -n "Nome do projeto" | Criar com nome específico                                     |
| -h                 | Parâmetro de ajuda, para saber mais sobre o comando digitado. Usar na mesma linha do comando, no final do mesmo. | dotnet new -h                           | Mostra quais tipos de projeto disponíveis para serem criados. |
| cd NomePasta       | Abrirá o diretório informado.                                                                                    |                                         |                                                               |
| explorer .         | Abrirá o Windows Explorer na pasta em questão.                                                                   |                                         |                                                               |
| code .             | Abrirá o Visual Studio Code e nele, o conteúdo da pasta atual.                                                   |                                         |                                                               |
| dotnet restore     | Restaura/baixa/atualiza os pacotes que o projeto da pasta em questão precisa utilizar.                           |                                         |                                                               |
| dotnet build       | Faz todo o processo de compilação dos arquivos do projeto .NET da pasta em questão.                              |                                         |                                                               |
| dotnet run         | Roda o executável do projeto em questão.                                                                         | dotnet run -p Caminhosubpasta/          | Roda o executável do projeto salvo no caminho informado.      |

## Criando uma aplicação console usando terminal do Windows (prompt ou mesmo o Git Bash)

Usando o comando acima "dotnet new console" na pasta que desejar criar o projeto. Para colocar um nome específico, tem o comando "dotnet new console -n "Nome do projeto"".

## Conhecendo o C#

### O que é C#?

É uma linguagem de programação orientada a objeto e fortemente tipada. Tem sintaxe similar a do C, C++ ou Java e suporta conceitos de encapsulamento, herança e polimorfismo.

Os programas são executados no .NET (CLR e conjunto unificado de libraries de classes).

O compilador atual é o Roslyn.

### Como funciona?

O código-fonte escrito no C# é compilado para a IL (linguagem intermediária). O código e os recursos do IL são salvos em disco em um executável chamado assembly, com a extensão .exe ou .dll.

Dúvida: seriam as dll's na verdade "executáveis" como os .exe são para nós, mas para os próprios .exe?

Quando o programa C# é executado, o assembly é carregado no CLR. Depois este executa a compilação JIT para transformar o IL em instruções de máquina.



Código em C# > IL > linguagem de máquina

O CLR tem outros recursos, como:

* Garbage Collector, para coletar o "lixo" da aplicação, liberando recurso não utilizado pela mesma;

* Exception Handler, que serve para controlar possíveis execuções com erro da aplicação;

* Resources Manager, ou gerenciador de recursos que a aplicação possa precisar.

![](estrutura-projeto-csharp.png)

O .NET também tem uma extensa biblioteca de classes, com diversas funcionalidades, desde manipulação de arquivos, caracteres, banco de dados, entre outros.

## Conhecendo variáveis e instruções

### Tipos de valor

Tipos de variáveis:

* Numéricos: sbyte, short, int, long, byte, ushort, uint, ulong

* Caracteres unicode: char

* Pontos flutuantes: float, double, decimal

* Booleano: bool

* Outros: enum, struct e tipos nullable (Exemplo: int?)

Variáveis de tipos de referência: armazenam referências a seus dados, não os dados em si. Em um local na memória, tem a variável com determinado valor, e em outro local na memória fica armazenada a variável de referência a este valor. Servem para armazenarem toda uma cadeia de dados, ou para a grosso modo, "trazerem" todo um bloco de dados para que o programa trabalhe com esses dados todos de uma forma melhor organizada, em algum momento. Pra que ficar digitando a criação de variável por variável no código, se podemos escrever no código de uma forma mais fácil, reutilizando esses mesmos recursos em vez de ficar criando na unha toda vez que fossem usadas?

Tipos de Referência:

* Tipos Classe: class, object, string

* Tipos Arrays: int[], int[,], etc...

* Outros: interface, delegate

### Instruções em programas

Há as expressões em bloco, com o símbolo de "{}". 

Há também da declaração de variáveis e constantes, usando os tipos acima.

Declarações de condições, como if, switch, while, do, for, foreach.

Outras instruções, como break, continue, return, throw, try .. catch .. finally, using.



## Referências

[.NET Foundation](https://dotnetfoundation.org)

[How to: View assembly contents | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/assembly/view-contents)

[Programação funcional: O que é? | Alura Cursos Online](https://www.alura.com.br/artigos/programacao-funcional-o-que-e?gclid=EAIaIQobChMIrKeW54zn9AIVBMDICh3-pQxDEAAYASAAEgJfW_D_BwE)

[Entenda a programação funcional em 12 minutos - YouTube](https://www.youtube.com/watch?v=BWFpUHPqh1g)

[Conemu](https://conemu.github.io/)
