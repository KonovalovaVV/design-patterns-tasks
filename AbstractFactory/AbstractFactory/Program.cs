using AbstractFactory.Constants;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarConfig CurrentConfig = CarConfig.Standard;
            ICarFactory currentFactory = GetCarFactory(CurrentConfig);
            Car currentCar = new Car(currentFactory);
        }

        private static ICarFactory GetCarFactory(CarConfig carConfig)
        {
            switch (carConfig)
            {
                case CarConfig.Economy:
                    return new EconomyFactory();
                case CarConfig.Standard:
                    return new StandardFactory();
                case CarConfig.Extra:
                    return new ExtraFactory();
                default:
                    throw new System.Exception($"It's not possible to create a car factory for the type {carConfig}");
            }
        }
    }

}
