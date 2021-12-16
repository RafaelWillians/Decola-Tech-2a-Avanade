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

## O que é, como e onde usar .NET

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

## Conhecendo a CLI do .NET

## Criando uma aplicação console

## Referências

[.NET Foundation](https://dotnetfoundation.org)

[How to: View assembly contents | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/assembly/view-contents)

[Programação funcional: O que é? | Alura Cursos Online](https://www.alura.com.br/artigos/programacao-funcional-o-que-e?gclid=EAIaIQobChMIrKeW54zn9AIVBMDICh3-pQxDEAAYASAAEgJfW_D_BwE)

[Entenda a programação funcional em 12 minutos - YouTube](https://www.youtube.com/watch?v=BWFpUHPqh1g)
