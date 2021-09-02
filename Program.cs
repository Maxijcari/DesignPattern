using DesignPattern.DependencyInjection;
using DesignPattern.FactoryPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var log = Singleton.Log.Instance;

            //log.Save(DateTime.Now.ToString());

            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(10);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);

            var beer = new Beer("Pikantus","Erdinger");
            var drinkWithBeer = new DrinkWithBeer(10,1,beer);

            drinkWithBeer.Build();

        }
    }
}
