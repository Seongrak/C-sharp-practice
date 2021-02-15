using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 7;
            int[] myArray = new int[] { 1, 4, 5, 7, 9, 22 };

            Console.WriteLine("My array contains:");
            Array.ForEach(myArray, x => Console.Write(x + " "));

            Console.Write($"\n\n The result of a linear search" +
                             $"for {theValue} is : ");

            Console.WriteLine(linearSearch(myArray,theValue));

            Console.ReadLine();
        }
        
        static int linearSearch(int[] a, int x) // a = array, x = what we are searching
        {

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i; // index of the value in the array
                }
            }

            return -1;
        }
    }
}
