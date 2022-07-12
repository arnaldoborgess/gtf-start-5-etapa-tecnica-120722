using static System.Console;

namespace Conta
{
    public abstract class Conta
    {
        public int Rendimento { get; set; }

        public void Valor()
        {
            WriteLine($"Seu saldo é R${Valor} Reais.");
        }
    }
}