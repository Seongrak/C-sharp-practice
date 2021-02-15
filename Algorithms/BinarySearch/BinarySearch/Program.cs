using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] myArray = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our array contains:");
            Array.ForEach(myArray, x => Console.Write(x + " "));

            Console.Write($"\n\n The result index of a binary search for {theValue} is :");
            Console.WriteLine(binarySearch(myArray, theValue));

            Console.ReadLine();
        }

        // a = array
        // x = what we're searching
        // p = first index
        // q = midpoint
        // r = last index

        public static int binarySearch(int[] a, int x) 
        {
            int p = 0; // beginning of the range
            int r = a.Length - 1; // the end of the range = last slot

            while (p <= r)
            {
                int q = (p + r) / 2; // find the midpoint

                if (x < a[q])
                    r = q - 1; // set r to midpoint.

                else if (x > a[q])
                    p = q + 1; // set p to midpoint.

                else return q; // return the index of result
            }
          
            // When we can't find the value
            return -1; 
        }
    }
}
