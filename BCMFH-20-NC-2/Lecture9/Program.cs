namespace Lecture9
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }

        public abstract void Drive();
    }

    interface ILoadCargo
    {
        void LoadCardgo();
    }

    interface IRingBell
    {
        void RingBell();
    }

    public class Car : Vehicle
    {
        public Car(string make, string model, string fuelType)
        {
            Make = make;
            Model = model;
            FuelType = fuelType;
        }

        public override void Drive()
        {
            Console.WriteLine($"{Make} {Model} is driving with {FuelType} fuel.");
        }
    }


    public class Truck : Vehicle, ILoadCargo
    {
        public Truck(string make, string model, string fuelType)
        {
            Make = make;
            Model = model;
            FuelType = fuelType;
        }

        public override void Drive()
        {
            Console.WriteLine($"{Make} {Model} is driving with {FuelType} fuel.");
        }

        public void LoadCardgo()
        {
            Console.WriteLine($"{Make} {Model} is loading cargo.");
        }
    }


    public class Bicycle : Vehicle, IRingBell
    {
        public Bicycle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public override void Drive()
        {
            Console.WriteLine($"{Make} {Model} is driving without fuel.");
        }

        public void RingBell()
        {
            Console.WriteLine($"{Make} {Model} is ringing a bell.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car("Toyota", "Corolla", "Petrol");
            Vehicle myTruck = new Truck("Volvo", "FMX", "Diesel");
            Vehicle myBicycle = new Bicycle("TestBike", "TestBikeModel");

            myCar.Drive();
            myTruck.Drive();
            myBicycle.Drive();

            Console.WriteLine("--------------------------------");

            if (myTruck is ILoadCargo truck)
            {
                truck.LoadCardgo();
            }

            if (myBicycle is IRingBell ringBell)
            {
                ringBell.RingBell();
            }
        }
    }
}
