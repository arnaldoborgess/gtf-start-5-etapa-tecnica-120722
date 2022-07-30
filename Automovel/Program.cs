
using Automovel.Models;

internal class Program
{
    private const string V = "Caminhao";

    private static void Main(string[] args)
    {
        Caminhao caminhao = new Caminhao();
        caminhao.Combustivel = "Diesel";

        Esportivo esportivo = new Esportivo();
        esportivo.Combustivel = "Gasolina";

    
        string Automoveis = "Esportivo";

        if (Automoveis == "Caminhao")
        {
            caminhao.Apresentar();
        }
        else
        {
            esportivo.Apresentar();
        }



    }
}