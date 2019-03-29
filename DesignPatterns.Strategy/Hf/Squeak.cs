using System;

namespace DesignPatterns.Strategy.Hf
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
