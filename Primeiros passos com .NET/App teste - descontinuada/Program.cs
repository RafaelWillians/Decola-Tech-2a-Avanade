using System;
#nullable disable

/*
Cadastro de Alunos:
Inserir Nome do Aluno, Nota. Ambos, armazenados em um array.
Depois, informar nome e nota de todos os alunos.
Temos que criar um Struct para o Aluno receber tanto string do nome, quanto
int da nota.
No compilador do VSCode, tive problemas para utilizar diretamente o Console.ReadLine.
Acabei implementando igual a forma que o prof. Gabriel Faraday mostrou, utilizando tratativa
com condição (if com TryParse), para tentar ler no console a nota ou dar erro se for null.


Encontrei uma alternativa para corrigir esse erro, de previamente identificar no código possível retorno null:

No início do código, inserir #nullable disable. Porém pesquisando outras formas de implementar sem forçar
o código todo a desativar a checagem. Talvez esse prolema ocorra por conta do .NET 6.0 e/ou do C# 10
identificarem os tipos como não-nulos por padrão.


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
            

            Console.WriteLine("Olá! \n Cadastro de Aluno");
            Console.WriteLine("ALUNO: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("NOTA: ");
            if(int.TryParse(Console.ReadLine(), out int x))
            {
                aluno.Nota = x;
                Console.WriteLine($"NOME ALUNO DIGITADO: {aluno.Nome}");
                Console.WriteLine($"NOME ALUNO DIGITADO: {aluno.Nota}");
                Console.ReadLine();
            }
            else
            {
                throw new ArgumentException("Valor inválido!");
                Console.WriteLine("Erro!");
                Console.ReadLine();
            }
                       




            
            //Console.WriteLine($"NOME ALUNO DIGITADO: {aluno.Nome}");
            /*if(!string.IsNullOrEmpty(aluno.Nome))
            {
                Console.WriteLine($"Nome aluno digitado: {aluno.Nome}");
            }*/


            /*
            
            */      

        }
    }
}
