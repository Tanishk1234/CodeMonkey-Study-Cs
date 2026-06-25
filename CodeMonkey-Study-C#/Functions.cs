namespace CodeMonkey_Study
{
    internal class Program
    {

        #region Methods

        // Method is a block of code that performs a specific task.
        // A method can take parameters and can also return a value.
        // In C#, functions are called methods because they belong to a class.

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Calling a method
            // PrintHelloWorld("Tanishk", 35);

            // Calling a method that returns a value
            // Console.WriteLine(AddNumbers(5, 10));

            // Using the returned value as an argument
            // PrintHelloWorld("Tanishk", AddNumbers(10, 5));

            // Store the returned value inside a variable
            // int number = AddNumbers(1, 2);
            // Console.WriteLine(number);

            // Console.WriteLine(IsPositive(5) + ";" + IsPositive(-2));

            // Read two numbers from the keyboard
            // Console.ReadLine() always returns a string
            // Convert.ToInt32() converts the string into an integer
            // IsPositive() checks whether the number is positive or not
            // + is used to join multiple strings together

            Console.WriteLine(
                IsPositive(Convert.ToInt32(Console.ReadLine()))
                + ";" +
                IsPositive(Convert.ToInt32(Console.ReadLine()))
            );
        }

        #region Void Method

        // void method is used when you only want to perform some action
        // it does not return any value back to the place where it was called

        static void PrintHelloWorld(string playerName, int age)
        {
            // parameters are variables which receive values when the method is called

            // Console.WriteLine("Hello World");

            // string interpolation is used to insert variables inside a string
            // Console.WriteLine($"Hello {playerName}, you are {age} years old");
        }

        #endregion


        #region Method With Return Value

        // int before the method name means this method returns an integer value
        // return keyword sends the value back to the place where the method was called

        static int AddNumbers(int X, int Y)
        {
            // add both numbers and return the result
            return X + Y;
        }

        #endregion


        #region Method Overloading

        // method overloading means using the same method name
        // but with different parameters
        // compiler automatically calls the correct method based on the arguments

        static int AddNumbers(int X, int Y, int Z)
        {
            // return the sum of three numbers
            return X + Y + Z;
        }

        #endregion


        #region Boolean Method

        // bool method always returns either true or false
        // this method checks whether the number is positive or not

        static bool IsPositive(int x)
        {
            // if number is greater than or equal to 0 then return true
            if (x >= 0)
            {
                return true;
            }
            else
            {
                // otherwise return false
                return false;
            }

            // Short version:
            // return x >= 0;
            // this directly returns the result of the comparison
        }

        #endregion
    }
}
