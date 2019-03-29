namespace DesignPatterns.Strategy.Ic
{
    public class Context
    {
        private IChoice _choice;
        public void SetChoice(IChoice choice)
        {
            _choice = choice;
        }

        public void ShowChoice()
        {
            _choice.MyChoice();
        }
    }
}
