using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car currentCar;
            CarFactory currentFactory;
            config currentConfig = config.standart;
            switch(currentConfig)
            {
                case config.economy:
                    currentFactory = new EconomyFactory();
                    break;
                case config.standart:
                    currentFactory = new StandartFactory();
                    break;
                case config.extra:
                    currentFactory = new ExtraFactory();
                    break;
                default:
                    currentFactory = new EconomyFactory();
                    break;
            }
            currentCar = new Car(currentFactory);

        }
    }

}
