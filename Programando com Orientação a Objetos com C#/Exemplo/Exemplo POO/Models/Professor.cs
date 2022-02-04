using System;
namespace Exemplo_POO.Models
{
    /*
    Definindo a classe conforme abaixo resultará em erro, pois com a classe Professor
    selada, a classe Diretor não pode herdar dela.

    public sealed class Professor : Pessoa
    */
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        /*
        Definindo como sealed o método Apresentar conforme abaixo, resultará em erro, pois a classe
        Diretor está tentando sobrescrever o método.

        public sealed override void Apresentar()
        */

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Nome do Professor: {Nome} - Idade: {Idade} anos - Salário: {Salario}");
        }
                
    }
}