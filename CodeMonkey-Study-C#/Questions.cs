using System.Numerics;

namespace CodeMonkey_Study
{
    internal class Program
    {
        #region Question 1 MultiplyNumbers
        //Create a method named MultiplyNumbers.

        //*****Requirements:*****//
        /*The method should take 2 integer parameters.
        It should return the multiplication of those two numbers.
        Call the method from Main().
        Store the returned value in a variable named result.
        Print the result using Console.WriteLine().*/

        /*
        static void Main(string[] args)
        {
            int result = MultiplyNumbers(10 , 10);
            // Write your code here
            Console.WriteLine(result);
            //output : 100
        }

        // Write your method here
        static int MultiplyNumbers(int x , int y)
        {
            return x * y;
        }
        */

        #endregion

        #region Question 2 IsAdult

        //Create a method named IsAdult.
        //*****Requirements:*****//
        /* 
        The method should take 1 integer parameter (age).
        Return true if age >= 18.
        Otherwise return false.
        In Main(), ask the user to enter their age using Console.ReadLine().
        Convert the input to an integer.
        Call IsAdult().
        Print the returned value.
        */
        /*
        static void Main(string[] args)
        {
            // Write your code here
            Console.WriteLine(IsAdult(Convert.ToInt32(Console.ReadLine())));
          
        }

        // Write your method here
        static bool IsAdult(int age)
        {
            return age >= 18;
        }
        */
        #endregion

        #region Question 3 FindLargest

        //Write a method named FindLargest
        //*****Requirements:*****//
        /* 
        It should take 2 integer parameters.
        Return the larger number.
        If both numbers are equal, return either one.
        In Main()
          Read 2 numbers from the keyboard.
          Call FindLargest().
          Print the returned value.
        */

        /*
        static void Main(string[] args)
        {
            // Write your code here
            int result = FindLargest(10, 20);
            Console.WriteLine($"Largest Number Was {result}");

        }

        // Write your method here
        static int FindLargest(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        */
        #endregion

        #region Question 4 IsEven

        //*****Requirements:*****//

        // It should take one integer parameter

        // Return true if the number is even

        // Otherwise return false

        /*
        static void Main(string[] args)
        {
            // Read one number from the keyboard

            // Call the method
            bool result = IsEven(Convert.ToInt32(Console.ReadLine()));
            // Print the returned value
            Console.WriteLine(result);
        }

        // Create a method named IsEven
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //In Short
            //return number % 2 == 0
        }
        */
        #endregion

        #region Question 5 CalculateGrade

        //*****Requirements:*****//

        // It should take one integer parameter called marks

        // Return:
        // "A" if marks >= 90
        // "B" if marks >= 75
        // "C" if marks >= 50
        // "Fail" otherwise

        /*
        static void Main(string[] args)
        {
            // Read marks from the keyboard
            // Call CalculateGrade()
            string result = CalculateGrade(Convert.ToInt32(Console.ReadLine()));
            // Print the returned grade
        }


        // Create a method named CalculateGrade
        static string CalculateGrade(int marks)
        {
            if (marks >= 90)
            {
                return "A";
            }
            else if(marks >= 75)
            {
                return "B";
            }
            else if(marks >= 50)
            {
                return "C";
            }
            else
            {
                return "Fail";
            }

        }
        */
        #endregion
    }
}
