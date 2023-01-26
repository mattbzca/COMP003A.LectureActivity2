/*
 * Author: Matthew Tan
 * Course: COMP-003A
 * Purpose: Lecture activity for variables, type system, Math, and Console properties
 * Reference: The C# Player's Guide (4e) by RB Whitaker
*/
namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* working with variables */
            // the following code shows all three primary variable-related activities:
            string username; // declaring a variable (1 of 3)
            Console.WriteLine("What is your name?"); // request for user input
            username = Console.ReadLine(); // assigning a value to a variable (2 of 3)
            Console.WriteLine("Hi " + username); // retrieving its current value (3 of 3)

            
            // another example of the three primary variable related activities (declaring, assigning, and retrieving)
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);


            /* working with variable integers */
            int score; // declare a new variable with a data type int
            // score = "Generic User"; //will fail to compile because you are assigning a string value to an integer variable
            //score = "0"; // will still fail to compile because the "0" is still assigned as a string - enclosed in the double quotes
            score = 0; // works
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;


            /* variables are case-sensitive */
            // the variables below are different despite having similar names
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("**************************************************");
            /*
             * types of variables and values matter in C#. they are not interchangable.
             * there are eight integer types for storing integers of differing sizes and ranges: int, short, long, byte, sbyte, uint, ushort, and ulong.
             * the char type stores single characters.
             * the string type stores longer text.
        }
    }
}