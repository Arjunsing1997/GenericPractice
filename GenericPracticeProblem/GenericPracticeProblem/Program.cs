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
            public T first, second, third;
            public PrintArray(T first, T second, T third)//Creating an Constructor
            {
                this.first = first;
                this.second = second;
                this.third = third;
            }
            public static T MaxValues(T first, T second, T third)
            {
                if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                   first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                   first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
                {
                    return first;
                }

                if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                   second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                   second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
                {
                    return second;
                }

                if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 ||
                   third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 ||
                   third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
                {
                    return third;
                }
                return first;
            }
            public T MaxMethod()
            {
                T max = PrintArray<T>.MaxValues(this.first, this.second, this.third);
                return max;
            }
        }

        



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ----------GENERIC PROBLEMS-----------------");

            //Creating and Assigning Values to array
            //int[] intArray = { 10, 20, 30 };
            //double[] doubleArray = { 10.10, 20.20, 30.30 };
            //char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            PrintArray<int> generic1 = new PrintArray<int>(10, 20, 30);
            Console.WriteLine("Integer Max Number--->"+generic1.MaxMethod());
            PrintArray<double> generic2 = new PrintArray<double>(10.4, 20.6, 30.1);
            Console.WriteLine("Double Max Number--->"+generic2.MaxMethod());
            PrintArray<char> generic3 = new PrintArray<char>('a','b','c');
            Console.WriteLine("Charecter Max Letter--->"+generic3.MaxMethod());

            Console.ReadLine();
        }
    }
}
