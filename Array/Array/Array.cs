using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Input array length value (n): ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);


            int[] arr = new int[n];


            Random rnd = new Random();
            Console.WriteLine("Array was filled by random values (-100, 100).");
            for (int i = 0; i < n; ++i)
            {
                arr[i] = rnd.Next(-100, 100);
                Console.WriteLine(arr[i] + " ");
            }


            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sorted in ascending order: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.WriteLine("Enter a number you want to search");
            int xnumber = Int32.Parse(Console.ReadLine());

            int first = 0;
            int last = n - 1;
            int current;
            int output;
            int k = -1;
            
            while (first <= last)
            {
                current = (first + last) / 2;
                if (arr[current] == xnumber)
                {
                    output = current;
                    Console.WriteLine("Number found. Index is: " + "[" + output + "]");
                    Console.ReadKey();
                    k = arr[output];
                    break;
                }
                else if (arr[current] < xnumber)
                {
                    first = current + 1;
                }
                else
                {
                    last = current - 1;
                }
            }
            if (k != xnumber)
            {
                Console.WriteLine("Number was not found.");
                Console.ReadKey();
            }
        }
    }
}

