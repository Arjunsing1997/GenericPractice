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

        public  int MaxIntNumber(int first,int second, int third)
        {
            if(first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
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
        public double MaxDoubleNumber(double first, double second, double third)
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
        public string MaxChar(string first, string second, string third)
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
