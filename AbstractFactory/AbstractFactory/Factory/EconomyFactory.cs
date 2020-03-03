internal class EconomyFactory : ICarFactory
{
    public IEngine CreateEngine()
    {
        return new EconomyEngine();
    }

    public IWheel CreateWheel()
    {
        return new EconomyWheel();
    }

    public ISuspension CreateSuspension()
    {
        return new EconomySuspension();
    }
}