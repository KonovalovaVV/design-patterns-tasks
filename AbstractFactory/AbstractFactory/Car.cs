using AbstractFactory.Suspension;
using AbstractFactory.Wheel;
using AbstractFactory.Engine;
using AbstractFactory.Factory;


namespace AbstractFactory
{
    internal class Car
    {
        public ISuspension Suspension { get; }
        public IWheel Wheel { get; }
        public IEngine Engine { get; }

        public Car(ICarFactory factory)
        {
            Engine = factory.CreateEngine();
            Wheel = factory.CreateWheel();
            Suspension = factory.CreateSuspension();
        }

        public bool Start()
        {
            return Engine.Start();
        }
    }
}