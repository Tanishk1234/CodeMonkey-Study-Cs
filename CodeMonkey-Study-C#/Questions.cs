using System.Numerics;

namespace CodeMonkey_Study
{
    internal class Program

        //Question 1(Basics - Variables & Functions)
        //Write a C# program that creates a method named MultiplyNumbers. The method should return the multiplication of two numbers entered by the user.

        //Question 2(Basics - Variables & Functions)
        //Write a C# program that creates a method named IsAdult. Read the user's age from the keyboard and display whether the user is an adult.

        //Question 3(Basics - Variables & Functions)
        //Write a C# program that creates a method named FindLargest. Read two numbers from the keyboard and display the largest number.

        //Question 4(Basics - Variables & Functions)
        //Write a C# program that creates a method named IsEven. Read a number from the keyboard and display whether the number is even or odd.

        //Question 5(Basics - Variables & Functions)
        //Write a C# program that creates a method named CalculateGrade. Read a student's marks from the keyboard and display the grade according to the following:
        //90 or above → A
        //75–89 → B
        //50–74 → C
        //Below 50 → Fail

        //Bonus Question 6(Basics - Variables & Functions)
        //Write a method named FindSmallest that returns the smaller of two numbers.

        //Bonus Question 7(Basics - Variables & Functions)
        //Write a method named IsPositive that returns whether a number is positive or negative.

        //Bonus Question 8(Basics - Variables & Functions)
        //Create a method named SquareNumber that returns the square of a number.

        //Question 9(Basics - Array & Loop's)
        //Read 5 numbers into an array and print all the numbers using a for loop.

        //Question 10(Basics - Array & Loop's)
        //Question 9(Basics - Array & Loop's)
        //Question 9(Basics - Array & Loop's)
        //Question 9(Basics - Array & Loop's)
        //Question 9(Basics - Array & Loop's)
        //Question 9(Basics - Array & Loop's)
        //Question 9(Basics - Array & Loop's)

        
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

        #region Question 6 FindSmallest

        /*

        static void Main(string[] args)
        {
            int result = FindSmallest(10, 20);
            Console.WriteLine($"Smallest Number Was {result}");
        }

        // Write your method here
        static int FindSmallest(int x, int y)
        {
            if (x < y)
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

        #region Question 7 IsPositive

        /*

        static void Main(string[] args)
        {
            // Read one number from the keyboard

            // Call the method

            bool result = IsPositive(Convert.ToInt32(Console.ReadLine()));
            // Print the returned value
            Console.WriteLine(result);
        }

        // Write your method here
        static bool IsPositive(int number)
        {
            if(number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        */
        #endregion
        
        #region Question 8 SquareNumber
        /*
            
            static void Main(string[] args)
            {
                int result = SquareNumber(5);   
            }
    
            static int SquareNumber(int number)
            {
                return number * number;
            }
        */
        #endregion
      
            #region Question 9 - ReadNumbers
        /*
            static void Main(string[] args)
            {
                int[] readNum = {5 , -5 , 7 , 6 , 8 };
    
                for (int i = 0; i < readNum.Length; i++)
                {
                    Console.WriteLine(readNum[i]);
                    //Dont remember to add [i] in last 
                }
            }
        */
        #endregion
        /*
        
        */

        /*
        
        */

        /*
        
        */

        /*
        
        */
        
    }
}
