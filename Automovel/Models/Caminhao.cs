namespace Automovel.Models
{
    public class Caminhao : Automoveis
    {
        public string Diesel { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Caminhão utiliza {Combustivel}");
        }

    }
}