using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSemFactory
{
    internal class PizzaCalabreza
    {
        public string Name { get; set; }

        public PizzaCalabreza()
        {
            Name = "Pizza de Calabreza";
        }

        public void Preparar()
        {
            Console.WriteLine($"\nPreparando pizza de {Name}");
        }

        public void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Name} assando por {tempo} min.");
        }

        public void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Name}\n");
        }
    }
}
