using System;
using System.Collections.Generic;
using System.Linq;
namespace exc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> integerList = new List<int>() { 1,2,3,4,5,6,7,8,9,10};//Data source
            var MethodSyntax=integerList.Where(obj=>obj>5).ToList();//Linq queary using method syntax
            foreach(var item in MethodSyntax)//Execution
            {
                Console.Write(item+"");
            }
            Console.ReadKey();
        }
    }
}
