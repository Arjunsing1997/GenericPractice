using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    class Program
    {
        public static void IntegerArray(int[] array)
        {
            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
        }

        public static void DoubleArray(double[] array)
        {
            foreach (double item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
        }

        public static void CharArray(char[] array)
        {
            foreach (char item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ----------GENERIC PROBLEMS-----------------");

            //Creating and Assigning Values to array
            int[] intArray = { 10, 20, 30 };
            double[] doubleArray = { 10.10, 20.20, 30.30 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            //Calling Methods in Main Mehtod
            Program.IntegerArray(intArray);
            Program.DoubleArray(doubleArray);
            Program.CharArray(charArray);

            Console.ReadLine();



        }
    }
}
