internal class ExtraFactory : ICarFactory
{
    public IEngine CreateEngine()
    {
        return new ExtraEngine();
    }

    public IWheel CreateWheel()
    {
        return new ExtraWheel();
    }

    public ISuspension CreateSuspension()
    {
        return new ExtraSuspension();
    }
}