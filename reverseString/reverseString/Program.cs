using System; 

namespace reverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Reverse a string without using the library function
            Console.Write("Enter a string to reverse: ");
            string str = Console.ReadLine();

            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i]; 
            }

            Console.WriteLine("Reversed string: " + reverse);
        }
    }
}
