using System;

namespace _19._04task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( " largest in given" + " array is " + largest());
        }
        static int[] arr = { 21, 36, 45, 65, 12, 35 };
        static int largest()
        {
            int i;
            int max = arr[0];

            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
            
            

            
        }

    }
}
