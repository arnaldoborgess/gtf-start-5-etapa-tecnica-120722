using System;

namespace Automovel.Models;

    public class Automoveis
    {
        public string Combustivel { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Esportivo utiliza {Combustivel}");
        }

    }
    


