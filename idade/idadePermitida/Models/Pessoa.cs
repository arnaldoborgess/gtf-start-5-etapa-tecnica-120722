using System;

namespace idadePermitida.Models;

public class Pessoa
{
    public int Idade { get; set; }
    public string Nome { get; set; }
    
    public void Apresentar()
    {
        Console.WriteLine($"Sua idade é: {Idade} e seu nome é {Nome} ");
    }

}
