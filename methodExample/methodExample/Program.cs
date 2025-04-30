using System.ComponentModel.DataAnnotations;

namespace methodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display(19, 22);
            Display(11);//Default parameter
            //Display(secondNumber: 22, thirdNumber: 19);// Named parameters
            //Display(19, 22, 33);
            //Display(19.5, 22);
            //Display(19, 22.5);
        }
        //public static void Display(int firstNumber, int secondNumber)
        //{
        //    Console.WriteLine($"First Number is: {firstNumber} and Second Number is: {secondNumber}");
        //}
        //public static void Display(Double firstNumber, Double secondNumber)
        //{
        //    Console.WriteLine($"First Number is: {firstNumber} and Second Number is: {secondNumber}");
        //}
        public static void Display(int firstNumber, int secondNumber=33, int thirdNumber = 0)
        {
            Console.WriteLine($"First Number is: {firstNumber}, Second Number is: {secondNumber} and Third Number is: {thirdNumber}");
        }
    }
}
