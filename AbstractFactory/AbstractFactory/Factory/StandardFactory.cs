internal class StandardFactory : ICarFactory
{
    public IEngine CreateEngine()
    {
        return new StandardEngine();
    }

    public IWheel CreateWheel()
    {
        return new StandardWheel();
    }

    public ISuspension CreateSuspension()
    {
        return new StandardSuspension();
    }
}