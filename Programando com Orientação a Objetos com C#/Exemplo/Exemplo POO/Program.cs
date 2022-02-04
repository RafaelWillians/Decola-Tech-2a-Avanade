using System;
using Exemplo_POO.Models;

namespace Exemplo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = TextoInicio();
            /*
            Instanciada classe de conta corrente aqui, para sempre somar 150, 
            quando for selecionada opção 6 - Classe Abstrata.
            Esta opção mostrará um exemplo de creditar 150 em uma conta, utilizando
            a classe abstrata Conta.cs e usando a classe filha Corrente.cs.
                        

            */

            Corrente c1 = new Corrente();
            
            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //Exemplo de Abstração - utiliza classe Pessoa.cs
                        System.Console.Clear();
                        System.Console.WriteLine("---EXEMPLO ABSTRAÇÃO - DADOS PESSOA---");
                        Pessoa p1 = new Pessoa();
                        p1.Nome="Claudio";
                        p1.Idade = 14;
                        p1.Apresentar();
                        System.Console.WriteLine("");
                        System.Console.WriteLine("");                          
                    break;
                    case "2":
                        //Exemplo de Encapsulamento - utiliza classe Retangulo.cs
                        System.Console.Clear();
                        Retangulo ret = new Retangulo();
                        int inputComprimento = 0;
                        int inputLargura = 0;                                
                        System.Console.WriteLine("---EXEMPLO ENCAPSULAMENTO - ÁREA RETÂNGULO---");
                        System.Console.WriteLine("COMPRIMENTO: ");            
                        if (int.TryParse(System.Console.ReadLine(), out int numComprimento))
                        {
                            inputComprimento = numComprimento;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da medida deve ser do tipo inteiro!");
                        }
                        System.Console.WriteLine("LARGURA: ");            
                        if (int.TryParse(System.Console.ReadLine(), out int numLargura))
                        {
                            inputLargura = numLargura;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da medida deve ser do tipo inteiro!");
                        }
                        ret.DefinirMedida(inputComprimento, inputLargura);            
                        System.Console.WriteLine($"AREA: {ret.ObterArea()}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("");
                    break;
                    case "3":
                        //Exemplo de Herança
                        System.Console.Clear();
                        Aluno a1 = new Aluno();
                        Professor prof1 = new Professor();            
                        System.Console.WriteLine("---EXEMPLO HERANÇA - NOTA ALUNO E SALÁRIO PROFESSOR---");
                        System.Console.WriteLine("DIGITE A NOTA DO ALUNO: ");            
                        if (int.TryParse(System.Console.ReadLine(), out int nota))
                        {
                            a1.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser do tipo inteiro!");
                        }
                        System.Console.WriteLine("DIGITE O SALÁRIO DO PROFESSOR: ");
                        if(double.TryParse(System.Console.ReadLine(), out double sal))
                        {
                            prof1.Salario = sal;
                        }
                        else
                        {
                            throw new ArgumentException("O salário deve ser do tipo real!");
                        }
                        System.Console.WriteLine($"NOTA ALUNO: {a1.Nota}");
                        System.Console.WriteLine($"SALÁRIO PROFESSOR: {prof1.Salario}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("");
                    break;
                    case "4":
                        /*
                        Exemplo de Polimorfismo - Override
                        Aqui mostrará não apenas o nome e a idade, mas também a Nota, conforme
                        feito override no método Apresentar da classe Pessoa, na classe Aluno
                        e na classe Professor
                        */
                        System.Console.Clear();
                        System.Console.WriteLine("---EXEMPLO POLIMORFISMO - OVERRIDE---");
                        Aluno a2 = new Aluno();
                        a2.Nome = "Miguel";                        
                        a2.Idade = 23;
                        a2.Nota = 8;
                        a2.Apresentar();

                        System.Console.WriteLine();

                        Professor prof2 = new Professor();
                        prof2.Nome = "Eduardo";
                        prof2.Idade = 42;
                        prof2.Salario = 4200;
                        prof2.Apresentar();

                    break;
                    case "5":
                        /*
                        Exemplo de Polimorfismo - Overload - usando um mesmo método de duas formas
                        diferentes, passando um parâmetro a mais na segunda soma.
                        */
                        System.Console.Clear();                         
                        System.Console.WriteLine("---EXEMPLO POLIMORFISMO - OVERLOAD---");
                        Calculadora calc1 = new Calculadora();                        
                        System.Console.WriteLine("Resultado primeira soma = " + calc1.Somar(2, 5));
                        System.Console.WriteLine("Resultado segunda soma = " + calc1.Somar(2, 5, 16));
                    break;
                    case "6":                        
                        System.Console.Clear();
                        System.Console.WriteLine("---EXEMPLO CLASSE ABSTRATA---");
                        string opcaoConta = c1.InicioConta();
                        while(opcaoConta.ToUpper() != "X")
                        {
                            switch(opcaoConta)
                            {
                                case "1":
                                    System.Console.Clear();
                                    c1.ExibirSaldo();
                                break;
                                case "2":
                                    double deposito = 0;
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Valor a depositar: ");
                                    if(double.TryParse(Console.ReadLine(), out double valorcreditar))
                                    {
                                        deposito = valorcreditar;
                                    }
                                    else
                                    {
                                        throw new ArgumentException("Aceito somente valor numérico com ou sem os centavos!"); 
                                    }
                                    System.Console.Clear();
                                    c1.Creditar(deposito);
                                    c1.ExibirDeposito(deposito);                                                                        
                                    c1.ExibirSaldo();
                                break;
                                case "3":
                                    double saque = 0;
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Valor a sacar: ");
                                    if(double.TryParse(Console.ReadLine(), out double valordebitar))
                                    {
                                        saque = valordebitar;
                                    }
                                    else
                                    {
                                        throw new ArgumentException("Aceito somente valor numérico com ou sem os centavos!"); 
                                    }
                                    System.Console.Clear();
                                    c1.Debitar(saque);
                                    c1.ExibirSaque(saque);
                                    c1.ExibirSaldo();
                                break;
                                default: 
                                    throw new ArgumentOutOfRangeException();
                            }
                            opcaoConta = c1.InicioConta();

                        }
                        //limpar o console ao sair do exemplo de Classe Abstrata
                        System.Console.Clear();
                        
                        /*
                        Exemplo mais simples, para testar a classe abstrata. 

                        System.Console.WriteLine("Creditados R$ 150,00 na conta.");
                        c1.Creditar(150);
                        c1.ExibirSaldo();
                        */

                    break;
                    case "7":
                        //Exemplo de uso de classe selada
                        System.Console.Clear();
                        System.Console.WriteLine("---EXEMPLO CLASSE SELADA---");
                        Diretor dir1 = new Diretor();
                        dir1.Nome = "Claudio";
                        dir1.Idade = 51;
                        dir1.Salario = 10000;

                        
                        dir1.Apresentar();
                        System.Console.WriteLine();
                        System.Console.WriteLine("Mostrado texto com a palavra 'professor', ");
                        System.Console.WriteLine("pois a classe Professor está selada.");
                        System.Console.WriteLine("Ou seja, não é possível sobrescrever o método Apresentar,");
                        System.Console.WriteLine("que consta na classe Professor");

                    break;
                    case "8":
                        Computador comp = new Computador();
                        System.Console.WriteLine("---EXEMPLO DE USO DE MÉTODO DA CLASSE System.Object---");
                        System.Console.WriteLine("Alterado método ToString na classe Computador.");
                        System.Console.WriteLine("Retorno do método ToString: ");
                        System.Console.WriteLine(comp.ToString());
                    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = TextoInicio();

            }
            
        }
        private static string TextoInicio()
        {
            Console.WriteLine();
            Console.WriteLine("PROGRAMANDO COM ORIENTAÇÃO A OBJETOS COM C#");
            Console.WriteLine("Opções disponíveis:");
            Console.WriteLine("1 = ABSTRAÇÃO");
            Console.WriteLine("2 = ENCAPSULAMENTO");
            Console.WriteLine("3 = HERANÇA");
            Console.WriteLine("4 = POLIMORFISMO - OVERRIDE");
            Console.WriteLine("5 = POLIMORFISMO - OVERLOAD");
            Console.WriteLine("6 = CLASSES ABSTRATAS");
            Console.WriteLine("7 = CLASSE SELADA");
            Console.WriteLine("8 = CLASSE OBJECT");
            Console.WriteLine("9 = INTERFACE");
            Console.WriteLine("10 = MANIPULANDO ARQUIVOS");            
            Console.WriteLine("X = SAIR");
            Console.WriteLine("__________________________");
            Console.WriteLine("Digite a opção: ");   

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine("");
            return opcaoUsuario;
        }
    }
}
