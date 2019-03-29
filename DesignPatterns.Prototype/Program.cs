using System;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public class Person
    {
        public string[] Names;
        public Address Address;
        public Person(string[] names,Address address)
        {
            if (names == null)
            {
                throw new ArgumentNullException(paramName: nameof(names));
            }
            if (address == null)
            {
                throw new ArgumentNullException(paramName: nameof(address));
            }
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
        }
    }

    public class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Calculator()
        {

        }
        public static Calculator operator +(Calculator calculator, int a) {
           calculator.X += a;
            return calculator;
        }
        public override string ToString()
        {
            return $"{nameof(X)}: {X},{nameof(Y)}: {Y}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.X = 1;
            calculator.Y = 2;
            calculator += 3;
            Console.WriteLine(calculator);
            Console.Read();
        }
    }
}
