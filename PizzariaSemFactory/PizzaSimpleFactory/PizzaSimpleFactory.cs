using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimpleFactory
{
    public sealed class PizzaSimpleFactory
    {
        public static Pizza CriaPizza(string tipo)
        {
            Pizza pizza;
            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabreza(); break;
                case "M":
                    pizza = new PizzaCalabreza(); break;
                default:
                    throw new ApplicationException($"A pizza de '{tipo}' não foi criada");
            }

            return pizza;
        }
    }
}
