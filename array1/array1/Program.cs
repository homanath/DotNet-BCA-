namespace array1
   
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //WAP to find the largest element from an array of 10 elements.
            int[] num = new int[10];
            Console.Clear();
            for (int i = 0; i < num.Length; i++) {
                Console.Write("Enter {0}th number:", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your number are  below:");
            foreach (int n in num)
            {
                Console.Write(n.ToString() + "\t");
            }
        }
    }
}
