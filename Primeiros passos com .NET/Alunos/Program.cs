using System;

/*
Cadastro de Alunos:
Inserir Nome do Aluno, Nota. Ambos, armazenados em um array.
Depois, informar nome e nota de todos os alunos.
Temos que criar um Struct para o Aluno receber tanto string do nome, quanto
int da nota

*/



namespace CadastroAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            //int x = 0;
            var aluno = new Aluno();

            if(int.TryParse(Console.ReadLine(), out int x))
            {
                aluno.Nota = x;
                Console.WriteLine($"VALOR: {x}");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Erro!");
                Console.ReadLine();

            }


            
            




            

        }
    }
}