using System;

namespace DesignPatterns.Strategy.Hf
{
    /// <summary>
    /// 绿头鸭
    /// </summary>
    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck.");
        }
    }
}
