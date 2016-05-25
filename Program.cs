using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingUsingProcedures
{
    class Program
    {
        static Random rnd = new Random();
        static bool sorted = false;
        static void Main(string[] args)
        {
            
            int[] nums = new int[10];
            Console.Write("\n*****Random Number Generating and Sorting*****\n\n");
            BuildRandoms(nums);
            Label();
            Print(nums);
            Sort(nums);
            Label();
            Print(nums);
            Pause();
        }
        static void Label()
        {
            //Labels the list section according to whether or not the list has been sorted
            if (sorted == false)
            {
                Console.WriteLine("\nNot Sorted:\n");
            }
            else
            {
                Console.WriteLine("\nSorted:\n");
            }
        }
        static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue.....");
            Console.ReadLine();
        }
        static void BuildRandoms(int[] ar)
        {
            sorted = false;

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(0, 1000);
            }
        }
        static void Sort(int[] ar)
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < ar.Length - 1; i++)
                {
                    if (ar[i] > ar[i + 1])
                    {
                        //put "ar[1]" into a temporary spot
                        //int temp = ar[i];
                        //ar[i] = ar[i + 1];
                        //ar[i + 1] = temp;
                        Swap<int>(ref ar[i], ref ar[i + 1]);
                        swapped = true;
                        sorted = true;
                    }
                }
            } while (swapped == true);
        }
        static void Print(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(i.ToString() + ". " + ar[i]);
            }
        }
        //generic method to swap any type that is passed through it
        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
}
