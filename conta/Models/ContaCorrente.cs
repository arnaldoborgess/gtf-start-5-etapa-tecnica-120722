namespace conta.Models
{
    public class ContaCorrente : Conta
    {
        private double saldo;

        public override void Rendimentos(double valor)
        {
            base.saldo = valor * 0.03;
        }

        public override void ExibirRendimentos()
        {
            System.Console.WriteLine($"Seu Rendimento na conta corrente é de: R$ {base.saldo} reais.");
        }

    }
}