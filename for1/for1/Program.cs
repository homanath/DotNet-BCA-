namespace for1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //WAP s progrma to check wether a number is prime or composit

            int num;
            Console.Write("number hal na hom bhai xitoo\nk toile new khojeko xito hall euta number:\n-->");
            num = Convert.ToInt32(Console.ReadLine());
            if ( num==1) {
                Console.WriteLine($"{num} ae bhai yo anka  kei pani hoina.");
                return;
            }
            if (Isprime(num))
                Console.WriteLine($"{num} ae bhai yo anka prime anka ho."); 
            else
                Console.WriteLine($"{num} ae bhai yo composit anka .");

        }
        static bool Isprime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}

