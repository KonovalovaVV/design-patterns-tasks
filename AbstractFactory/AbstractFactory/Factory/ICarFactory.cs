using AbstractFactory.Suspension;
using AbstractFactory.Wheel;
using AbstractFactory.Engine;

namespace AbstractFactory.Factory 
{ 
    internal interface ICarFactory
    {
        IEngine CreateEngine();
        ISuspension CreateSuspension();
        IWheel CreateWheel();
    }
}