namespace conta.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente corrente = new ContaCorrente();
            corrente.Rendimentos(50);

            corrente.ExibirRendimentos();

            ContaPoupanca poupanca = new ContaPoupanca();
            poupanca.Rendimentos(500);

            poupanca.ExibirRendimentos();

        }
    }

}
