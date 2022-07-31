using idadePermitida.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p = new Pessoa();

        Console.WriteLine("Digite sua idade:"); 
        p.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite seu nome:"); 
        p.Nome = Console.ReadLine();

        p.Apresentar();

        if (p.Idade => 18 || p.Idade >= 67)
        {
            Console.WriteLine($"Você pode doar sangue {p.Nome}.");
        }
        else
        {
            Console.WriteLine($"Que pena {p.Nome}, você ainda não tem idade para doar sangue.");
        }
    }
}