using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticeProblem
{
   public class Program
    {
        /// <summary>
        /// Using Generic class 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class PrintArray<T> where T : IComparable
        {
            public T[] value;
            public PrintArray(T[] value)//Creating an Constructor
            {
                this.value = value;
            }

            public T[] Sort(T[] value)
            {
                Array.Sort(value);  //dorting an Array
                return value;
            }
            public T MaxValues(T[] value)
            {
                var sorted_values = Sort(value);    //calling sort method to sort an array
                return sorted_values[1];
            }
            public T MaxMethod()
            {
                var max = MaxValues(this.value); //calling MaxValue method and passing values to it
                return max;
            }
            public void PrintValues()
            {
                var max = MaxValues(this.value);
                Console.WriteLine("Maximum value is " + max);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ----------GENERIC PROBLEMS-----------------");

            //Creating and Assigning Values to array
            int[] intArray = { 10, 20, 30, 50 };
            double[] doubleArray = { 10.10, 20.20, 30.30 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            PrintArray<int> generic1 = new PrintArray<int>(intArray);   //creating an Object
            generic1.PrintValues();     //Calling a method using an Object
            PrintArray<double> generic2 = new PrintArray<double>(doubleArray);
            generic2.PrintValues();
            PrintArray<char> generic3 = new PrintArray<char>(charArray);
            generic3.PrintValues();
            Console.ReadLine();
        }
    }
}
