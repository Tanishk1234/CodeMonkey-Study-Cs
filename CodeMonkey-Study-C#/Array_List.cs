

namespace CodeMonkey_Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            // Array is used to store multiple values of the same data type
            // Array size is fixed, once created you cannot increase or decrease its size

            int[] numberArray = new int[3] { 56, 66, 77 };

            // Length property returns the total number of elements inside the array
            // Console.WriteLine(numberArray.Length);

            // Access element using index
            // Index always starts from 0
            // Console.WriteLine(numberArray[0]); // 56
            // Console.WriteLine(numberArray[1]); // 66
            // Console.WriteLine(numberArray[2]); // 77

            // Change the value at a specific index
            // numberArray[1] = 100;
            // Console.WriteLine(numberArray[1]);

            #endregion


            #region List

            // List is also used to store multiple values of the same data type
            // Unlike arrays, List size can increase and decrease at runtime

            List<int> numbersList = new List<int>();

            // Count returns the total number of elements inside the list
            Console.WriteLine(numbersList.Count); // 0

            // Add() is used to insert a new element into the list
            numbersList.Add(12);
            numbersList.Add(25);
            numbersList.Add(50);
            numbersList.Add(100);

            // Count increases after adding elements
            Console.WriteLine(numbersList.Count); // 4

            // Access elements using index
            Console.WriteLine(numbersList[0]); // 12
            Console.WriteLine(numbersList[1]); // 25
            Console.WriteLine(numbersList[2]); // 50
            Console.WriteLine(numbersList[3]); // 100

            // Change value at a specific index
            numbersList[1] = 30;
            Console.WriteLine(numbersList[1]); // 30

            // Contains() checks whether an element exists in the list
            Console.WriteLine(numbersList.Contains(50)); // True
            Console.WriteLine(numbersList.Contains(500)); // False

            // Remove() removes the first matching element
            numbersList.Remove(50);

            // RemoveAt() removes an element using its index
            numbersList.RemoveAt(0);

            // Insert() adds an element at a specific index
            numbersList.Insert(1, 75);

            // IndexOf() returns the index of an element
            Console.WriteLine(numbersList.IndexOf(100));

            // Clear() removes all elements from the list
            // numbersList.Clear();

            // Count becomes 0 after Clear()
            // Console.WriteLine(numbersList.Count);

            #endregion
        }
    }
}
