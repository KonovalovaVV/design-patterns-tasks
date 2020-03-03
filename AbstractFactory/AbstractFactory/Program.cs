namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car CurrentCar;
            ICarFactory CurrentFactory;
            CarConfig CurrentConfig = CarConfig.Standard;
            CurrentFactory = GetCarFactory(CurrentConfig);
            CurrentCar = new Car(CurrentFactory);
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
