using System;

internal class Car
{
    CarFactory factory;
    Suspension suspension;
    Wheel wheel;
    Engine engine;
    public Car(CarFactory f)
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
