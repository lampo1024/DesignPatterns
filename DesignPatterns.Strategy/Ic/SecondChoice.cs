using System;

namespace DesignPatterns.Strategy.Ic
{
    public class SecondChoice : IChoice,ISpecialChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("Traveling to USA");
        }

        public void MySpecialChoice()
        {
            Console.WriteLine("Traveling to USA");
        }
    }
}
