 namespace InheritanceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle v = new Vehicle(V1002);
            v.display();
            v = new Truck(1005, "Truck1003");
            v.display();
        }
    }

    public class Vehicle  
    {
        protected string vehicleNo = null!;
        protected string brand = null!;
        protected float fuelCapacity;

        public Vehicle(string vehivleNo)

        {
            fuelCapacity = 0;
            this.vehicleNo= vehivleNo;
        }
    }

    public class Car : Vehicle
    {
        private int seatCapacity;

        public Car()  
        {
            seatCapacity = 0;
            fuelCapacity = 0;
        }
    }

    public class Truck : Vehicle
    {
        private float maximumLoadCapacity;

        public Truck()
        {
            maximumLoadCapacity = 0;
            fuelCapacity = 0;
            vehicleNo = "Not registered";
            brand = "No brand";
        }

        public void setLoadCapacity(float maxCapacity)
        {
            maximumLoadCapacity = maxCapacity;
        }

        public float getLoadCapacity()
        {
            return maximumLoadCapacity;
        }
    }
}
