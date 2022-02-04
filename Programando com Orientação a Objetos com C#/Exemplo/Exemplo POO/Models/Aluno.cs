using System;
namespace Exemplo_POO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome do Aluno: {Nome} - Idade: {Idade} anos - Nota: {Nota}");
        }
    }
    

}