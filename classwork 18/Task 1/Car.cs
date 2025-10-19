using System;

namespace Task_1
{
    class Car : IVehicle
    {
        private int _fuel;

        public Car(int fuel)
        {
            _fuel = fuel;

            Console.WriteLine($"Car created with fuel amount of {_fuel}");
        }

        public void Drive()
        {
            if (_fuel > 0)
                Console.WriteLine($"Driving the car with fuel amount of {_fuel}");
            else
                Console.WriteLine("Car is not moving because of lack of fuel.");
        }

        public bool Refuel(int fuelAmount)
        {
            _fuel += fuelAmount;

            if (fuelAmount == 0)
                return false;

            return true;
        }
    }
}
