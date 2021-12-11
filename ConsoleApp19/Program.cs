using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program /*task5*/
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 18, 27, 2, 100, 0, -5, 77, -24, 99 };
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int j = 0;
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.WriteLine("Even:");
            for (int i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.WriteLine("\nOdd:");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
        }
    }
}