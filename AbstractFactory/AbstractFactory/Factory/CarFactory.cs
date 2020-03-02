using System;

internal interface CarFactory
{
    Engine createEngine();
    Suspension createSuspension();
    Wheel createWheel();
}