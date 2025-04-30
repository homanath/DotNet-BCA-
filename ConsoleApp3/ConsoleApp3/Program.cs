namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Wap to input a number and calculate the sum of its digits.
            int num, sum = 0, rem;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());            
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("Sum of digits of the number is: " + sum);
        }
    }
}
