using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
    class Program
    {
        /// <summary>
        /// Generics the specified array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array.</param>
        public static void Generic<T>(T[] array)
        {
            foreach(T item in array)
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
            Program.Generic(intArray);
            Program.Generic(doubleArray);
            Program.Generic(charArray);

            Console.ReadLine();



        }
    }
}
