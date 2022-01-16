namespace Exemplo_POO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedida(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores digitados inválidos!");                
            }
            
        }
        public double ObterArea()
        {
            if(valido)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Digite valores numéricos, maiores que zero!");
                return 0;
            }
            
        }

    }
}