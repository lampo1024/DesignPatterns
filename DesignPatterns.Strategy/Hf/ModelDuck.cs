using System;

namespace DesignPatterns.Strategy.Hf
{
    public class ModelDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
