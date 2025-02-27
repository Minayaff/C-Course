using System;
using System.Linq.Expressions;


namespace First_Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reference type : string, arrays

            int[,] arr = new int[3, 3]
            {
                {1,2,8 },
                {4,8,6},
                {5,6,4}

            };
            Console.WriteLine(arr[0,2]);

        }
    }

}