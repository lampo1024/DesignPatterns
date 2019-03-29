using System;

namespace DesignPatterns.Builder
{
    public delegate void OnStarting();
    public interface IBuilder
    {
        event EventHandler OnStarting;
        event EventHandler OnEnd;
        IBuilder AddHeadlights();
        IBuilder BuildBody();
        IBuilder EndOperations();
        Vehicle GetVehicle();
        IBuilder InsertWheels();
        IBuilder StartUpOperations();
    }
}
