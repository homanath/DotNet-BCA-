namespace interfaceExaample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyVechicle(new Car());
            MyVechicle(new Byd());
            Console.ReadKey();
        }
        public static void MyVechicle(IVehicle v)
        {
            v.Start();
        }
    }
    public interface IVehicle
    {
        public void Register();
        public void Start();
        public void Stop();
        public void PlayHorn();
    }
    public class Car : IVehicle
    {
        public void Register()
        {
            Console.WriteLine("New car has been registered.");
        }
    public void Start()
        {
            Console.WriteLine("I am starting now.");
        }   
    public void Stop()
        {
            Console.WriteLine("I am idle now.");
        }
    public void PlayHorn()
        {
            Console.WriteLine("Car says ........");
        }
    }
    public class Bike : IVehicle
    {
        public void Register()
        {
            Console.WriteLine("New bike has been registered.");
        }
        public void Start()
        {
            Console.WriteLine("I am starting now.");
        }
        public void Stop()
        {
            Console.WriteLine("I am idle now.");
        }
        public void PlayHorn()
        {
            Console.WriteLine("Bike says ........");
        }
    }
    public class Byd: Car
    {
        
    }
}