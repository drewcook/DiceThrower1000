using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDice("2d20");
            ThrowDice("5d150");
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");
            Console.ReadKey();
        }

        //functions go here
        static void ThrowDice(string diceString)
        {
            //create variable number of rolls, nubmer of sides, and the split
            string[] splitD = diceString.Split('d');
            //create variables for number of rolls since our input can now be indexed, we will call the first number the rolls and the second the sides
            string numRolls = splitD[0];
            string numSides = splitD[1];
            //create a variable for our total number of rolls to help find our average roll later
            int total = 0;
          
            
            //create a random number generator to run through numbers
            Random randNum = new Random();

            Console.WriteLine("\n\n===================New roll====================");

            //run a for loop to loop through each number
            //must convert numRolls from a string to an integer for the loop to work
            for (int i = 1; i <= int.Parse(numRolls); i++)
            {
                //create a variable to hold the random number generator between 1 and the numSides of the dice
                //convert the numSides from a string to number with int.Parse()
                int broal = randNum.Next(1, int.Parse(numSides));
                //print out to console with a space in between each roll
                Console.Write(broal + " ");
                //add one to total rolls
                total += broal;
            }
            //after loop is up, print the average roll by adding all the rolls to total (as done with the loop) and dividing by number of rolls
            Console.WriteLine();
            Console.WriteLine("Average Roll: " + total/int.Parse(numRolls));
            
        }
    }
}
