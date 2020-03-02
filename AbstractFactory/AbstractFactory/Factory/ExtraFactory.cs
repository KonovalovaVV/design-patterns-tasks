using System;

internal class ExtraFactory : CarFactory
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