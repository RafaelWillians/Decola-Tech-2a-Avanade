# Introdução ao C# e .NET

## O que é o .NET?

É um framework criado pela Microsoft que permite que várias linguagens de programação usem um ambiente em comum (exemplos: Visual Basic, C++, F#, C#), não precisando ser tudo numa linguagem só.

## O que é o C#?

É uma linguagem orientada a objetos fortemente tipada, baseada no C++ e com algumas influências de outras como Object Pascal e Java.

## Estruturas no C#

Antes, por que da Programação Orientada a Objetos? Para uma melhor organização do código e torná-lo mais próximo de objetos da vida real.

Na programação estruturada por exemplo, não há tanta restrição de acesso a variáveis na memória. Então, para um melhor controle e uso, para evitar que parte da aplicação tenha acesso a algo indevido (vazamento de escopo), criamos classes e a partir destas, objetos. Deixamos o "esqueleto", o "molde" que é a classe, com todas as especificações chave e com ela, criamos os objetos, a grosso modo "como se fosse uma cópia modificável dela", para que possamos trabalhar em cima desses objetos. 

[POO: o que é programação orientada a objetos? | Alura Cursos Online](https://www.alura.com.br/artigos/poo-programacao-orientada-a-objetos)

### Namespaces

São usados para organizar as classes. Ele pode englobar tanto classes quanto outros namespaces. Servem para serem referenciados no código, caso o desenvolvedor precise de grandes grupos de objetos e códigos, para a sua aplicação.

Para usarmos uma classe de outro namespace, colocamos "using" no começo do código.

Exemplo de namespace:

namespace Namespace1

{

}

Como faço pra acessar classe de outro namespace? Exemplo:

using System; 

public class Example 

{ 

    public static void Main() 

    {
         Console.Write("Hello ");
         Console.WriteLine("World!");
         Console.Write("Enter your name: ");
         String name = Console.ReadLine();
         Console.Write("Good day, ");
         Console.Write(name);
         Console.WriteLine("!");
     }
}

No exemplo acima, utilizamos o "using System;" para informarmos que utilizaremos o namespace "System" nesse código. Para que isso? Para que possamos utilizar a classe "Console" e seus métodos, como o "Write" e "WriteLine". Se tirarmos o "using" acima do código, dará erro na compilação.

### Classes e objetos

As classes são o nosso "molde" dos objetos, teremos os campos, propriedades, métodos e eventos nela. Nelas iremos definir tudo de característica que ela terá, como ela irá a princípio funcionar, quais valores retornar, etc.

Cada característica dessa é chamada de "membro" da classe.

Exemplo:

class Animal

{

    public string Nome {get; set;}

    public int Idade {get; set;} 

    public string Especie {get; set;}

}

Os "getters" e "setters" servem para essa classe possa receber ou nos informar por esse exemplo, qual o nome do Animal, qual a idade e espécie. Mas não é a classe em si que vai ter nome, idade ou espécie. Aqui é somente para informarmos que cada Animal **pode** ter um nome, idade ou espécie. 

Quando instanciamos uma classe, essa instância chamamos de "objeto". E continuando no exemplo acima, a partir dos objetos que então definimos qual o nome, idade ou espécie que esse animal específico (que é o objeto) tem. É como se "criássemos uma cópia" da classe, só para usarmos essa cópia como algo à parte e "editável". A classe em si fica lá, estática, com as características todas. Agora, cada animal será diferente do outro, então para cada animal diferente, é um objeto diferente.

Exemplo de instanciar um objeto:

Animal vertebrado= new Animal();

vertebrado.Nome = "Claudio";

vertebrado.Idade = 40;

vertebrado.Especie = "Humano";

### Interface

É como se fosse uma classe base, para outras classes.

A interface terá apenas métodos e a assinatura deles. Não terá atributos (você não pode declarar variáveis dentro da interface por exemplo).

Se for utilizar uma interface numa classe, é necessário informar na classe em si todos os métodos da Interface.

Uma classe por exemplo pode "herdar" múltiplas interfaces, ou seja, pode adotar métodos de várias interfaces diferentes.

Sempre adicionar letra "I" ou "i" no início do nome da interface.

Exemplo:

public interface IVeiculo

{

    void ligar();

    void desligar();

    void info();

}

public interface ICombate

{

    void disparar();

}

//aqui por exemplo, informamos que a classe Carro terá tanto os métodos da interface //IVeiculo, quanto da interface ICombate

class Carro:IVeiculo,ICombate

{

    //aqui implementamos os métodos das interfaces na classe Carro

    public bool ligado;

    private int municao;

    public Carro()

    {

        this.municao=100;

    }

    public void setMunicao(int qtde)

    {

        this.municao=qtde;

    }

    public void ligar();

    {

        this.ligado=true;

    }

    public void desligar();

    {

        this.ligado=false;

    }

    public void disparar()

    {

    }

    public void info()

    {

    }

}

class Teste

{

    static void Main()

    {

         Carro cl=new Carro();

    }   

}

[Interfaces - Curso Programação Completo C# - Aula 43 - YouTube](https://www.youtube.com/watch?v=NSjz4HS7bPU)

### Enum

Enum serve para declararmos constantes nomeadas, que o índice inicial é zero e vai incrementando de 1 em 1, como se fosse um vetor.

Exemplo:

enum Estacao

{

    primavera,

    verao,

    outono,

    inverno

}

Exemplo 2:

public enum Season
{
     Spring,
     Summer,
     Autumn,
     Winter
} 

public class EnumConversionExample 

{ 

    public static void Main() 

    {
         Season a = Season.Autumn;
         Console.WriteLine($"Integral value of {a} is {(int)a}"); 

        // output: Integral value of Autumn is 2 

         var b = (Season)1;
         Console.WriteLine(b); // output: Summer var c = (Season)4;
         Console.WriteLine(c); 

        // output: 4 

    }
}

## Debugging

Podemos inspecionar o código no momento que o depuramos. Pode ser feita passando o cursor do mouse por cima da variável, ou abrindo a janela QuickWatch pelo menu Depurar. É possível ver por exemplo como está o estado de uma variável, qual valor e tipo ela está recebendo.

A depuração é feita quando colocamos uma quebra no código (breakpoint), na hora que ele executa. Para que serve isso? Para pausadamente, linha por linha, identificarmos possíveis erros no código, aplicação, etc. Com os breakpoints, é possível vermos os estados, os retornos da aplicação por cada linha do código.

É possível marcarmos breakpoints clicando no canto mais à esquerda da tela do código, na linha que desejamos marcar.
