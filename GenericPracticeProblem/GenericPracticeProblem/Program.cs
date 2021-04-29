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
        /// Using Generic class 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class PrintArray<T>
        {
            private T[] array;
            public PrintArray(T[] array)//Creating an Constructor
            {
                this.array = array;
            }
            public void Generic()
            {
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------------------------");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ----------GENERIC PROBLEMS-----------------");

            //Creating and Assigning Values to array
            int[] intArray = { 10, 20, 30 };
            double[] doubleArray = { 10.10, 20.20, 30.30 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            //Calling Methods in Main Mehtod
           new PrintArray<int>(intArray).Generic();
           new PrintArray<double>(doubleArray).Generic();
            new PrintArray<char>(charArray).Generic();

            Console.ReadLine();
        }
    }
}
