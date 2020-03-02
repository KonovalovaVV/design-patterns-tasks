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
    enum config
    {
        economy, standart, extra
    }
    class Car
    {
        CarFactory factory;
        Suspension suspension;
        Wheel wheel;
        Engine engine;
        public Car (CarFactory f) 
        {
            factory = f;
        }
        public void createCar()
        {
            engine = factory.createEngine();
            wheel = factory.createWheel();
            suspension = factory.createSuspension();
        }
        public bool start()
        {
            return engine.start();
        }

    }
    
    interface Engine
    {
        bool start();
    }
    class EconomyEngine: Engine
    {
        public bool start()
        {
            return true;
        }
    }
    class StandartEngine: Engine
    {
        public bool start()
        {
            return true;
        }
    }
    class ExtraEngine: Engine
    {
        public bool start()
        {
            return true;
        }
    }

    interface Wheel
    {
        void doMove();
    }
    class EconomyWheel: Wheel
    {
        public void doMove() 
        {

        }
    }
    class StandartWheel : Wheel
    {
        public void doMove()
        {

        }
    }
    class ExtraWheel : Wheel
    {
        public void doMove()
        {

        }
    }

    interface Suspension
    {

    }
    class EconomySuspension: Suspension
    {

    }
    class StandartSuspension : Suspension
    {

    }
    class ExtraSuspension : Suspension
    {

    }

    interface CarFactory
    {
        Engine createEngine();
        Suspension createSuspension();
        Wheel createWheel();
    }
    class EconomyFactory: CarFactory
    {
        public Engine createEngine()
        {
            return new EconomyEngine();
        }
        public Wheel createWheel()
        {
            return new EconomyWheel();
        }
        public Suspension createSuspension()
        {
            return new EconomySuspension();
        }
    }
    class StandartFactory : CarFactory
    {
        public Engine createEngine()
        {
            return new StandartEngine();
        }
        public Wheel createWheel()
        {
            return new StandartWheel();
        }
        public Suspension createSuspension()
        {
            return new StandartSuspension();
        }
    }
    class ExtraFactory : CarFactory
    {
        public Engine createEngine()
        {
            return new ExtraEngine();
        }
        public Wheel createWheel()
        {
            return new ExtraWheel();
        }
        public Suspension createSuspension()
        {
            return new ExtraSuspension();
        }
    }
}
