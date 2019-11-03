using System;

namespace PurgeAndOrganize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program returns an array that has all duplicate elements removed, is sorted from least value to greatest value.");

            int[] array_1 = new int[] {1, 2, 4, 3};
            int[] array_2 = new int[] { 1, 4, 4, 4, 4, 4, 3, 2, 1, 2 };
            int[] array_3 = new int[] { 6, 7, 3, 2, 1 };

            var sorted = new Organizer();
            Console.WriteLine("Array 1:");
            sorted.Organize(array_1);
            Console.WriteLine();
            Console.WriteLine("Array 2:");
            sorted.Organize(array_2);
            Console.WriteLine();
            Console.WriteLine("Array 3:");
            sorted.Organize(array_3);

            Console.ReadKey();
        }
    }
}
