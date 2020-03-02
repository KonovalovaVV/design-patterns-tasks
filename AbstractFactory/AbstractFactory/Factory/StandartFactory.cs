using System;

internal class StandartFactory : CarFactory
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