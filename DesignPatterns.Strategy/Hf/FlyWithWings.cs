using System;

namespace DesignPatterns.Strategy.Hf
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!!");
        }
    }
}
