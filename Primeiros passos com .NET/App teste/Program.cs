using System;
//using System.Threading;

namespace App_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            int notaMedia = 0;
            int contadorMedia = 0;
            int indiceLista = 0;
            string opcaoUsuario = TextoInicial();
            Conceito conceitoGeral;
                       
            while (opcaoUsuario.ToUpper() != "X") //enquanto não for digitada a opção X
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("----CADASTRO DE ALUNO----");
                        Aluno aluno = new Aluno();
                        Console.WriteLine("Nome: ");                        
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Idade: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal idade))
                        {
                            aluno.Idade = idade;                     
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");
                        }

                        /*
                        A linha abaixo foi apenas para teste.
                        aluno.Idade = decimal.Parse(Console.ReadLine());
                        */
                        Console.WriteLine("Nota: ");
                        /*
                        A linha abaixo apenas de teste.
                        var nota = int.Parse(Console.ReadLine());
                        */
                        if(int.TryParse(Console.ReadLine(), out int nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota precisa ser inteiro!");
                        }
                        if(aluno.Nota <=0 || aluno.Nota >10)
                        {
                            Console.WriteLine("Nota precisa ser de 0 a 10!");
                        }
                        else
                        {
                            alunos[indiceAluno] = aluno;
                            indiceAluno++;                            
                        }
                        

                        /*
                        A linha abaixo foi apenas para teste.
                        aluno.Nota = int.Parse(Console.ReadLine());
                        */
                        break;
                    case "2":
                        
                        Console.WriteLine("----LISTAGEM DE ALUNOS----");
                        foreach(var a in alunos) //para cada aluno no array
                        {
                            if(!string.IsNullOrEmpty(a.Nome)) //se o nome não estiver com valor nulo ou vazio
                            {
                                var conceitoAluno = atribuirConceito(a.Nota);                                
                                Console.WriteLine($"ALUNO: {a.Nome} - IDADE: {a.Idade} - NOTA: {a.Nota} - CONCEITO: {conceitoAluno}");                                
                            }                            
                        }
                        /*
                        Anteriormente havia criado manualmente a listagem, sem o foreach

                        Console.WriteLine("NOME / IDADE / NOTA");
                        for(indiceLista = 0; indiceLista<=4; indiceLista++)
                        {
                            Console.WriteLine($"{alunos[indiceLista].Nome}");
                            Console.WriteLine($"{alunos[indiceLista].Idade}");
                            Console.WriteLine($"{alunos[indiceLista].Nota}");
                            Console.WriteLine();
                        }
                        */
                        break;
                    case "3":
                        /*
                        A forma abaixo é referente a uma implementação antiga,
                        para calcular manualmente uma média de um único aluno.
                        
                        Console.WriteLine("----CALCULAR MÉDIA NOTA----");
                        foi necessário inicializar o notaMedia aqui também, pois ocorria erro na compilação,
                        ao fazer a atribuição somando notaMedia a ela mesma, mais nota, dessa forma em loop
                        conforme abaixo.

                        notaMedia = 0;

                        for(contadorMedia = 1;contadorMedia<=4;contadorMedia++)
                        {
                            Console.WriteLine($"Digite a {contadorMedia}ª Nota: ");
                            if(int.TryParse(Console.ReadLine(), out int n))
                            {
                                notaMedia = notaMedia + n;
                            }
                            else
                            {
                                throw new ArgumentException("Valor da nota precisa ser do tipo inteiro!");
                            }

                        }
                        Console.WriteLine($"MÉDIA NOTA: {notaMedia/4}");
                        Console.WriteLine();
                        */

                        int notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome)) //se o nome do aluno não estiver com valor nulo ou vazio
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++; //aqui é o contador de alunos válidos
                            }
                        }
                        // para atribuir nota conceito e retornar erro de divisão por zero
                        try
                        {
                            var mediaGeral = notaTotal / nrAlunos;
                            conceitoGeral = atribuirConceito(mediaGeral);
                            Console.WriteLine($"MÉDIA GERAL: {mediaGeral}");
                            Console.WriteLine($"NOTA CONCEITO GERAL: {conceitoGeral}");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }
                /*
                Utilizei o comando abaixo, apenas para teste, para inserir um delay no texto.
                Thread.Sleep(100);
                */
                opcaoUsuario = TextoInicial();
            }
        }

        private static Conceito atribuirConceito(int mediaGeral)
        {
            Conceito conceitoGeral;
            switch(mediaGeral)
            {
                case < 3:
                conceitoGeral = Conceito.E;
                break;

                case < 5:
                conceitoGeral = Conceito.D;
                break;

                case < 7:
                conceitoGeral = Conceito.C;
                break;

                case < 9:
                conceitoGeral = Conceito.B;
                break;

                case >= 9:
                conceitoGeral = Conceito.A;
                break;

                default:
                        throw new ArgumentOutOfRangeException();

            }

            /*
            if (mediaGeral < 3)
            {
                conceitoGeral = Conceito.E;
            }
            else if (mediaGeral < 5)
            {
                conceitoGeral = Conceito.D;
            }
            else if (mediaGeral < 7)
            {
                conceitoGeral = Conceito.C;
            }
            else if (mediaGeral < 9)
            {
                conceitoGeral = Conceito.B;
            }
            else
            {
                conceitoGeral = Conceito.A;
            }
            */
            return conceitoGeral;
        }

        //Método para gerar texto inicial e solicitar a opção ao usuário.       

        private static string TextoInicial()
        {
            Console.WriteLine();
            Console.WriteLine("Opções disponíveis:");
            Console.WriteLine("1 = CADASTRAR ALUNO");
            Console.WriteLine("2 = LISTAR ALUNOS");
            Console.WriteLine("3 = CALCULAR MÉDIA GERAL");
            Console.WriteLine("X = SAIR");
            Console.WriteLine("__________________________");
            Console.WriteLine("Digite a opção: ");   

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine("");
            return opcaoUsuario;
        }
    }
}

