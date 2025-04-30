
namespace operationOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Distance d1 = new Distance(10,23);
            Distance d2 = new Distance(22, 89);
           
            Distance d3 = d1 + d2;
            //Distance d3 = d1.Add(d2);
            Distance d4 = -d3;
            d3.Display();
            d4.Display();
        }
    }
    
        public class Distance
    {
         public int Meter { get; set; }
        public int Centimeter { get; set;}
        public Distance()
        {
            Meter = 0;
            Centimeter = 0;
        }

        public Distance(int m,int c)
        {
            Meter = m;
            Centimeter = c;
        }
        public void Display()
        {
            Console.WriteLine($"My distance is {Meter} meter and {Centimeter} centimeter.");
        }
        public Distance Add(Distance d)
        {
            Distance d3 = new Distance(
                    this.Meter + d.Meter + (this.Centimeter + d.Centimeter) / 100,
                    (this.Centimeter + d.Centimeter) % 100
                );
            return d3;
        }
        public static Distance operator +(Distance d1, Distance d2)
        {
            Distance d3 = new Distance(d1.Meter + d2.Meter + (d1.Centimeter + d2.Centimeter) / 100,
                    (d1.Centimeter + d2.Centimeter) % 100);
            return d3;
        }
        public static Distance operator -(Distance d)
        {
            return new Distance(-d.Meter, -d.Centimeter);
        }
    }
}
