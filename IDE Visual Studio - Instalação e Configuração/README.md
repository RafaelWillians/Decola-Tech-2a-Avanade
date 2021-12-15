# IDE Instalação e Configuração (Visual Studio)

## Instalando e conhecendo a IDE

Link para download: [Baixar Ferramentas do Visual Studio – Instalação gratuita para Windows, Mac e Linux](https://visualstudio.microsoft.com/pt-br/downloads)

Baixar a versão Comunidade, pois a Profissional e Enterprise são pagas.

Durante a instalação, iremos instalar as cargas de trabalho, ou os recursos, tecnologias, que serão usadas para o desenvolvimento, como Python, ASP.NET, ferramentas para desenvolvimento com Android, etc. Não precisa instalar todas, somente as que iremos utilizar.

Para instalar mais recursos, no Visual Studio, clicar em Ferramentas > Obter Ferramentas e Funcionalidades ou abrindo direto pelo explorer o executável do Visual Studio Installer.

## Gerando código e debugging

### Geração de código

Para iniciarmos no Visual Studio, basta clicar em ''Criar um projeto''. É possível também por ele, clonarmos um repositório do GitHub ou Azure DevOps.

São disponibilizados templates de projetos, de acordo com as cargas de trabalho instaladas no Visual Studio.

Obs.: caso precise que o projeto esteja em alguma versão específica de .NET Framework, necessário antes instalar o framework que deseja através do Visual Studio Installer.

Nas versões mais recentes do Visual Studio, o código dos projetos de aplicação console está sendo apresentado sem a estrutura de program e class, de uma forma mais direta.

![](C:\Users\PC\Documents\Workspace\Decola-Tech-2a-Avanade\IDE%20Visual%20Studio%20-%20Instalação%20e%20Configuração\console.png)

[Alterações no modelo do C# no .NET 6 - .NET | Microsoft Docs](https://docs.microsoft.com/pt-br/dotnet/core/tutorials/top-level-templates)

Quando se cria um projeto, é criada uma solução. Uma solução pode ter vários outros projetos, recursos, arquivos, etc. Não necessariamente fica sendo uma solução = a um projeto.

### Inspeção de código e debugging

Podemos inspecionar o código no momento que o depuramos. Pode ser feita passando o cursor do mouse por cima da variável, ou abrindo a janela QuickWatch pelo menu Depurar. É possível ver por exemplo como está o estado de uma variável, qual valor e tipo ela está recebendo.

A depuração é feita quando colocamos uma quebra no código (breakpoint), na hora que ele executa. Para que serve isso? Para pausadamente, linha por linha, identificarmos possíveis erros no código, aplicação, etc. Com os breakpoints, é possível vermos os estados, os retornos da aplicação por cada linha do código.

## Integração com Git e GitHub

É possível tanto clonarmos um repositório existente, quanto criarmos um novo através do Visual Studio, tanto na tela inicial quanto no menu "Git". É possível efetuar pull e push através do próprio Visual Studio.
