namespace Exemplo_POO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valorcredito)
        {
            //Utilizando base, para atribuirmos o saldo da classe Conta, não da classe Corrente.
            base.saldo = base.saldo+valorcredito;            
        }
        public override void Debitar(double valordebito)
        {
            base.saldo = base.saldo-valordebito;
        }
    }
}