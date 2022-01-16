using System;
using Exemplo_POO.Models;

namespace Exemplo_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome="Claudio";
            p1.Idade = 14;
            p1.Apresentar();
        }
    }
}
