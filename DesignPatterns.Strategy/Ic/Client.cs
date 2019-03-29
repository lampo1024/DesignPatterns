using System;

namespace DesignPatterns.Strategy.Ic
{
    public class Client
    {
        public static void Run()
        {
            IChoice ic = null;
            var cxt = new Context();
            while (true)
            {
                Console.WriteLine("\nEnter ur choice(1 or 2)");
                var c = Console.ReadLine();
                if (c.Equals("exit"))
                {
                    break;
                }
                if (c.Equals("1"))
                {
                    ic = new FirstChoice();
                }
                else if (c.Equals("2"))
                {
                    ic = new SecondChoice();
                }
                cxt.SetChoice(ic);
                cxt.ShowChoice();
            }
            Console.ReadLine();
        }
    }
}
