using System;

namespace DesignPatterns.Builder
{
    public class CarBuilder : IBuilder
    {
        private string _brandName;
        private Vehicle _vehicle;
        public CarBuilder(string brandName)
        {
            _brandName = brandName;
            _vehicle = new Vehicle();
        }

        public event EventHandler OnStarting;
        public event EventHandler OnEnd;

        public IBuilder AddHeadlights()
        {
            _vehicle.Add("2 headlights are added.");
            return this;
        }

        public IBuilder BuildBody()
        {
            _vehicle.Add("This is a body of Car.");
            return this;
        }

        public IBuilder EndOperations()
        {
            OnEnd?.Invoke(this,null);
            return this;
        }

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public IBuilder InsertWheels()
        {
            _vehicle.Add("4 wheels are added.");
            return this;
        }

        public IBuilder StartUpOperations()
        {
            OnStarting?.Invoke(this, null);
            _vehicle.Add(string.Format("Car Model name :{0}", _brandName));
            return this;
        }
    }
}
