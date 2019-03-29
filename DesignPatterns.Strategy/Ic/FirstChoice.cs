using System;

namespace DesignPatterns.Strategy.Ic
{
    public class FirstChoice : IChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("Traveling to China");
        }
    }
}
