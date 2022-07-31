namespace conta.Models
{
    public class ContaPoupanca : Conta
    {
         private double saldo;

        public override void Rendimentos(double valor)
        {
            base.saldo = valor * 0.05;
        }

        public override void ExibirRendimentos()
        {
            System.Console.WriteLine($"Seu Rendimento na conta poupança é de: R$ {base.saldo} reais.");
        }

    }
}