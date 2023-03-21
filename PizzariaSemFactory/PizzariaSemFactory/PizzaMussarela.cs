using System;

namespace PizzariaSemFactory
{
    public class PizzaMussarela
    {
        public string Name { get; set; }

        public PizzaMussarela()
        {
            Name = "Pizza de Mussarela";
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
