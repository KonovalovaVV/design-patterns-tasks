using System;

internal class EconomyFactory : CarFactory
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