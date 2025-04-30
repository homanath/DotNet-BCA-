namespace ConstructureEg_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1= new Student();
            Console.WriteLine("Name"+s1.getName());
            Console.WriteLine("RollNo:" + s1.getRoll());
            Console.ReadKey();
        }
    }  
}
  