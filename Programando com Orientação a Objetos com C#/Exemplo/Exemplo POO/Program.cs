using System;
using Exemplo_POO.Models;

namespace Exemplo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de Abstração - utiliza classe Pessoa.cs
            Console.WriteLine("---EXEMPLO ABSTRAÇÃO - DADOS PESSOA---");
            Pessoa p1 = new Pessoa();
            p1.Nome="Claudio";
            p1.Idade = 14;
            p1.Apresentar();
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            //Exemplo de Encapsulamento - utiliza classe Retangulo.cs
            Retangulo ret = new Retangulo();
            int inputComprimento = 0;
            int inputLargura = 0;            
            Console.WriteLine("---EXEMPLO ENCAPSULAMENTO - ÁREA RETÂNGULO---");
            Console.WriteLine("COMPRIMENTO: ");            
            if (int.TryParse(Console.ReadLine(), out int numComprimento))
            {
                inputComprimento = numComprimento;
            }
            else
            {
                throw new ArgumentException("O valor da medida deve ser do tipo inteiro!");
            }
            Console.WriteLine("LARGURA: ");            
            if (int.TryParse(Console.ReadLine(), out int numLargura))
            {
                inputLargura = numLargura;
            }
            else
            {
                throw new ArgumentException("O valor da medida deve ser do tipo inteiro!");
            }
            ret.DefinirMedida(inputComprimento, inputLargura);            
            Console.WriteLine($"AREA: {ret.ObterArea()}");
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            //Exemplo de Herança
            Aluno a1 = new Aluno();
            Professor prof1 = new Professor();            
            Console.WriteLine("---EXEMPLO HERANÇA - NOTA ALUNO E SALÁRIO PROFESSOR---");
            Console.WriteLine("DIGITE A NOTA DO ALUNO: ");            
            if (int.TryParse(Console.ReadLine(), out int nota))
            {
                a1.Nota = nota;
            }
            else
            {
                throw new ArgumentException("O valor da nota deve ser do tipo inteiro!");
            }
            System.Console.WriteLine("DIGITE O SALÁRIO DO PROFESSOR: ");
            if(double.TryParse(Console.ReadLine(), out double sal))
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

            //
            
        }
    }
}
