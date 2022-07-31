using static System.Console;

namespace conta.Models
{
    public abstract class Conta
    {
        protected int numero { get; set; }
        protected string titular { get; set; }
        protected double saldo { get; set; }

        public abstract void Rendimentos(double valor);
        
        public virtual void ExibirRendimentos()
        {
            System.Console.WriteLine($"Seu Rendimento na conta corrente é de: R$ {saldo} reais.");
        }

    }
}