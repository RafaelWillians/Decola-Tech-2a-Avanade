# Programando com Orientação a Objeto com C#

## Conhecendo POO

POO é uma técnica de programação para um fim específico.

Os 4 pilares da POO são: Abstração, Encapsulamento, Herança e Polimorfismo.

Estruturamos conjuntos de dados como objetos da vida real, em que cada objeto tem suas definições (atributos) e comportamentos (métodos).

Existem as classes (a estrutura base, o molde dos objetos) e os objetos (as variações ou "cópias" das classes).

Paradigma de programação é diferente de linguagem de programação. Uma linguagem pode implementar mais de um paradigma. O paradigma em si é a forma, o modelo, e/ou as regras que seguiremos, para desenvolvermos com aquela(s) linguagem(ns) de programação.

Exemplos de paradigmas de programação: POO, programação funcional, programação estruturada, imperativa, orientada a eventos, lógica, etc.

Exemplos de linguagens de programação: C#, Java, Javascript, etc.

## Abstração

### [* Artigo novo - como resolver erro na extensão OmniSharp, ao tentar selecionar projeto no Visual Studio Code mais recente](Fix%20para%20extens%C3%A3o%20OmniSharp/README.md)

Seria para abstrair um objeto para um contexto específico, considerando apenas alguns atributos.

Seria por exemplo utilizar no objeto apenas alguns atributos ou métodos específicos, definidos na classe. 

## Encapsulamento

Serve para proteger e limitar alteração de propriedades de uma classe, para expor somente o necessário.

Tipos de modificadores de acesso: public, protected internal, protected, internal, private protected, private. 

## Herança

Permite reutilizar código de uma classe em outras. Serve para agrupar objetos de mesmo tipo, mas com características diferentes.

Exemplo de uma pessoa. A pessoa tem uma mãe, essa pessoa herdará certas características da mãe, porém terá outras diferentes. Ou em outro exemplo, criando uma classe chamada Pessoa. As classes Aluno e Engenheiro, por exemplo, herdam características da Pessoa.

## Polimorfismo

Para sobrescrevermos métodos das classes filhas, para se comportarem de forma diferente da classe mãe.

Declaramos o mesmo nome do método, porém mudamos no código como o método vai se comportar na classe filha.

### Polimorfismo em tempo de compilação (Overload/Early Binding)

O nome é o mesmo, porém é alterada a assinatura do método (no exemplo abaixo, só muda que terá um parâmetro a mais e retornará a soma dele com os outros existentes)

![](Imagens/polimorfismo-tempo-compilacao.png)

### Polimorfismo em tempo de execução (Override/Late Binding)

Declaramos uma propriedade "virtual" ao método da classe mãe, indicando que ela poderá ser sobrescrita, e "override" no método da classe filha, para sobrescrevermos o comportamento desse método nessa classe filha.

![](Imagens/polimorfismo-tempo-execucao.png)

## Classes abstratas

Serve para ser uma base para ser herdada. Não pode ser instanciada.

Tem como na classe abstrata, por exemplo, criar métodos abstratos, que servirão somente para serem sobrescritas pelas classes que herdam. Porém é obrigatório sobrescrever estes métodos nas classes filhas. 

![](Imagens/classe-abstrata.png)

### Classe selada

Serve para impedir que ela seja herdada. Há também métodos e propriedades seladas.

![](Imagens/classe-selada.png)

### Classe Object

A classe System.Object é a mãe de todas as classes na hierarquia do .NET.

Todas derivam da classe Object direta ou indiretamente. Ela tem como o objetivo trazer serviços de baixo nível para as classes filhas.

Alguns exemplos de métodos da System.Object:

![](Imagens/exemplos-object.png)

No exemplo abaixo, instanciando uma classe vazia de nome "Computador", vemos que mesmo com ela vazia, há métodos disponíveis para uso. São métodos herdados do System.Object.

![](Imagens/metodos-object.png)

No exemplo abaixo, modificamos o método ToString, herdado do System.Object, na classe Computador.

![](Imagens/tostring.png)

## Interfaces

Interfaces são como um contrato, que pode ser implementado por uma classe. É como uma lista de requisitos, que uma classe que a herdará deverá ter. 

Bem parecida como uma classe abstrata, porém no C#, não há o conceito de herança múltipla entre classes, ou seja, uma classe somente pode herdar de uma única classe.

Porém uma classe pode herdar mais de uma interface.

## Manipular arquivo

## Atalhos C#

Digitar ''cw'' = completa automaticamente no código com "System.Console.WriteLine();"

## Referências

[Programação Orientada a Objetos C#](https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop)

