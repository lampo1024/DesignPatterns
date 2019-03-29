namespace DesignPatterns.Strategy.Hf
{
    public abstract class Duck
    {

        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;

        public Duck()
        {
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior) {
            FlyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public abstract void Display();
    }
}
