using System;

namespace DesignPatterns.Prototype
{
    [Serializable]
    public class Address
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            if (streetName == null)
            {
                throw new ArgumentNullException(paramName: nameof(streetName));
            }
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }
    }
}