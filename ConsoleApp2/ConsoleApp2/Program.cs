namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //WAP to input 3 numbers and display the largest one.
           Console.WriteLine("Enter the first number:");
            int firstNumber=Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the third number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            if(firstNumber == secondNumber && firstNumber == thirdNumber)
            {
                Console.WriteLine("All the numbers are equal.");
            }
            else if(firstNumber>secondNumber && firstNumber>thirdNumber)
            {
                Console.WriteLine(firstNumber + "is the largest number.");
                Console.WriteLine($"{firstNumber} is largest number.");
                Console.WriteLine("{0} is the largest number.",firstNumber);
            }
          else if(secondNumber>thirdNumber)
            {
                Console.WriteLine(secondNumber + " is the largest number.");
            }
            else
            {
                Console.WriteLine(thirdNumber + " is the largest number.");
            }
            Console.ReadKey();
        }
    }
}
 