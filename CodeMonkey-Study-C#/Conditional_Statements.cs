namespace CodeMonkey_Study_C_
{
    internal class Conditional_Statements
    {
        static void Main(string[] args)
        {
            #region if / else Statement
            
            if (1 == 1 || 2 == 2 && 5 < 1)
            {
                Console.WriteLine("inside if statement");
                // && is logical operator which means and
                // its used to check if both conditions are true then it will execute the code inside the if statement
                // || is logical operator which means or
                // its used to check if any one of the conditions is true then it will execute the code inside the if statement
                // ! is logical operator which means not
                
            }
            else if (false)
            {
                Console.WriteLine("inside else if statement");
                // else if statement is used to check another condition if the first condition is false
                // you can have multiple else if statements
                // you can also have multiple conditions inside the else if statement

            }
            else
            {
                Console.WriteLine("inside else statement");
                // else statement is used to execute the code if the condition inside the if statement is false
                // you can have only one else statement
            }

            #endregion

            #region Switch Case

            string name = "Tanishk";
            if(name == "tanishk")
            {
                Console.WriteLine("You entered tanishk");
            }
            else if(name == "TANISHK")
            {
                Console.WriteLine("you entered TANISHK");
            }
            else 
            {
                Console.WriteLine($"Correct name was {name}");
            }

            switch (name) 
            {
                case "Tanishk":
                    Console.WriteLine("your name is Tanishk");
                    break;
                case "Iron Man":
                    Console.WriteLine("your name is Iron Man");
                    break;
                default:
                    Console.WriteLine("your name is not Tanish");
                    break;

            }
            //default case is used to execute the code if none of the cases are matched
            //diffrence between if else and switch case is that if else can check multiple conditions and switch case can only check one condition
            //you can use switch case when you have multiple values to check for a single variable and if else when you have multiple conditions to check for a single variable
            //if else is more flexible than switch case because you can use multiple conditions and multiple variables in if else but in switch case you can only use one variable and one condition
            //optimiazation is better in switch case because it uses jump table and if else uses linear search which takes more time to execute the code
            

            #endregion

             

        }
    }
}
