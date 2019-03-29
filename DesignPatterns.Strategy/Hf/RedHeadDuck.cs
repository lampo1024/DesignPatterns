using System;

namespace DesignPatterns.Strategy.Hf
{
    public class RedHeadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a red head duck.");
        }
    }
}
