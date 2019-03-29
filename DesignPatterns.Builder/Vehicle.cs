using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class Vehicle
    {
        private List<string> _parts;
        public Vehicle()
        {
            _parts = new List<string>();
        }
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct completed as below :");
            foreach (string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
