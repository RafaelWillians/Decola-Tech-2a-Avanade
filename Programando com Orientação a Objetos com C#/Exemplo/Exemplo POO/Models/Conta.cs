using System;
namespace Exemplo_POO.Models
{
    public abstract class Conta
    {
        // Sendo protected, somente a própria classe e as classes filhas poderão acessar esse método
        protected double saldo;
        

        //Abstrato, logo não terá implementação aqui.
        public abstract void Creditar(double valor);

        public abstract void Debitar(double valordebito);

        //Implementaremos código nesse método aqui mesmo, logo não será abstrato.
        public void ExibirSaldo()
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"SALDO CONTA: {saldo}");
            System.Console.WriteLine();
        }
        public string InicioConta()
        {
            
            System.Console.WriteLine("**Conta Corrente**");            
            System.Console.WriteLine("1 - Saldo");
            System.Console.WriteLine("2 - Depósito");
            System.Console.WriteLine("3 - Saque");
            System.Console.WriteLine("X - SAIR");
            System.Console.WriteLine("Digite a opção desejada: ");
            string opcaoConta = Console.ReadLine();
            return opcaoConta;
        }
        public void ExibirDeposito(double deb)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"VALOR DE R$ {deb} DEPOSITADO COM SUCESSO!");
        }
        public void ExibirSaque(double cred)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"VALOR DE R$ {cred} SACADO COM SUCESSO!");
        }
    


    }
}