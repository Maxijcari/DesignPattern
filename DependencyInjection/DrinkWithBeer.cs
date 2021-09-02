using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjection
{
    public class DrinkWithBeer
    {
        //Este parametro esta mal y es lo que la Inyeccion de dependencia resuelve.
        private Beer _beer = new Beer("Pikantus","Erdinger");
        
        
        private decimal _water;
        private decimal _sugar;

        public DrinkWithBeer(decimal water,decimal sugar,Beer beer) 
        {
            _water = water;
            _sugar = sugar;
            _beer = beer;
        }

        public void Build() 
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {_water} "+$" azúcar {_sugar} y cerveza {_beer.Name}");
        }
    }
}
