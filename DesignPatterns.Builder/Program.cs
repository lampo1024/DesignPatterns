using System;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            IBuilder b1 = new CarBuilder("Ford");
            b1.OnStarting += Builder_OnStarting;
            b1.OnEnd += Builder_OnEnd;
            director.Construct(b1);            
            var car = b1.GetVehicle();
            car.Show();

            IBuilder b2 = new MotorCycleBuilder("LiFan");
            b2.OnStarting += Builder_OnStarting;
            director.Construct(b2);
            b2.OnEnd += Builder_OnEnd;
            var motor = b2.GetVehicle();
            motor.Show();

            Console.ReadLine();
        }

        private static void Builder_OnEnd(object sender, EventArgs e)
        {
            Console.WriteLine("\nBuild completed.");
        }

        private static void Builder_OnStarting(object sender, EventArgs e)
        {
            Console.WriteLine("\nStarting build...");
        }
    }
}
