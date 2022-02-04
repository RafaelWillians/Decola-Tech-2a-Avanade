using System;

namespace Exemplo_POO.Models
{
    public class Pessoa
    {
        public string Nome{get; set;}
        public int Idade {get; set;}

        public virtual void Apresentar ()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade} anos");
        }
        /*public void Apresentar ()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade} anos");
        }
        */
    }
}