namespace Automovel.Models
{
    public class Esportivo : Automoveis
    {
        public string Gasolina { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Esportivo utiliza {Combustivel}");
        }

    }
}