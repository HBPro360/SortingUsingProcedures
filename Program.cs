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
            if (sorted == false)
            {
                Console.WriteLine("Not Sorted:\n");
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
                        //put nums[1] into a temporary spot
                        int temp = ar[i];
                        ar[i] = ar[i + 1];
                        ar[i + 1] = temp;
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
    }
}
