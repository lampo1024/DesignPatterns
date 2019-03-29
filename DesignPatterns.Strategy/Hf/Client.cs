using System;

namespace DesignPatterns.Strategy.Hf
{
    public  class Client
    {
        public static void Run()
        {
            var md = new MallardDuck();
            md.SetFlyBehavior(new FlyWithWings());
            md.SetQuackBehavior(new Quack());
            md.Display();
            md.PerformFly();
            md.PerformQuack();

            var rd = new RedHeadDuck();
            rd.SetFlyBehavior(new FlyNoWay());
            rd.SetQuackBehavior(new Squeak());
            rd.Display();
            rd.PerformFly();
            rd.PerformQuack();

            var mdd = new ModelDuck();
            mdd.SetFlyBehavior(new FlyNoWay());
            mdd.SetQuackBehavior(new MuteQuack());
            mdd.Display();
            mdd.PerformFly();
            mdd.PerformQuack();

            Console.ReadLine();
        }
    }
}
