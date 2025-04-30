namespace example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wap to find the largest element from a n array.
            int[] myNums = {23, 45, 67, 89, 12, 34, 56, 78, 90, 11 };
            Console.WriteLine("My numbers in array using foreach are:");
            foreach (int i in myNums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("My numbers in array using for loop are:");
            for (int i = 0; i < myNums.Length; i++)
            {
                Console.WriteLine(myNums[i]);
            }
            Console.WriteLine("\nMy numbers in array using GetLengthh are:");
            for (int i = 0; i < myNums.GetLength(0); i++)
            {
                Console.WriteLine(myNums[i]);
            }
        }
    }
}
