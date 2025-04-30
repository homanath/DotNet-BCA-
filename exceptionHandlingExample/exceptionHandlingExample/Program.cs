namespace exceptionHandlingExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                if(a< 0 || b < 0)
                {
                    Exception e=new Exception("Negative number is not allowed.");
                    throw e;
                }
                c = a / b;
                Console.WriteLine("Result if a/b is:" + c);
            }
            catch (DividedByZeroException e)
            {
             
                    Console.WriteLine("Error Occured." + e.Message);
                    Console.WriteLine(e.StackTrace);
             }
            catch(Exception e)
            {
                Console.WriteLine("Unknown error occurred." + e.Message);
            }
             Console.WriteLine("End of program.");
            }
        }
    
    }

