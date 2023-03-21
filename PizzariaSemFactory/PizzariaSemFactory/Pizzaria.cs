using System;

namespace PizzariaSemFactory
{
    internal class Pizzaria
    {
        public  static void SolicitaPizza()
        {
            PizzaCalabreza pizza1;
            PizzaMussarela pizza2;

            Console.WriteLine("=================Pizzaria===============");
            Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussela");

            var pizzaEscolhida = Console.ReadLine().ToUpper();

            if (pizzaEscolhida.Equals("C"))
            {
                pizza1 = new PizzaCalabreza();
                pizza1.Preparar();
                pizza1.Assar(10);
                Console.WriteLine("pizza concluida");
            }
            else if (pizzaEscolhida.Equals("M"))
            {
                pizza2 = new PizzaMussarela();
                pizza2.Preparar();
                pizza2.Assar(10);
                Console.WriteLine("pizza concluida");
            }
            else
            {
                Console.WriteLine("Essa pizza não existe");
            }
        }
    }
}
