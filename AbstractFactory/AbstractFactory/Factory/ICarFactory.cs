internal interface ICarFactory
{
    IEngine CreateEngine();
    ISuspension CreateSuspension();
    IWheel CreateWheel();
}