using idadePermitida.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p = new Pessoa();

        Console.WriteLine("Digite sua idade:"); 
        p.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite seu Nome"); 
        p.Nome = Console.ReadLine();

        p.Apresentar();

        if (p.Idade > 18 || p.Idade >= 67)
        {
            Console.WriteLine($"Você Pode votar {p.Nome}.");
        }
        else
        {
            Console.WriteLine($"Você não pode votar ainda, {p.Nome}.");
        }
    }
}