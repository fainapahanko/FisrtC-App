using System;
using System.Collections;
using System.Collections.Generic;
/* # PART 1: C# basics #
Create a console application that executes the following instructions.
​
    Ex1: 
    Creates a variable PI of type double with the number 3.14 in it.
    Writes on the screen the result of casting PI to int.
​
    Ex2:
    Create a new double variable which stores the value of PI, converts it to decimal and writes it on the screen.
​
    Ex3:
    Use boxing to assign false, "camel" and 34 to the same variable x.
    Declare another variable y of type string.
    Try to use unboxing to treat x as if it were a string, and put its UPPERCASE version into y.
    Watch the program explode and the world burn, promising you'll never do that again.
​
    Ex4: 
    Create an array of string called Names and initialize its entries.
        Remember you could create arrays this way: variableType[] variableName = new variableType[X], where X = size of the array
        and then access them by index like: variableType[0] = Y
​
    Print the names on the screen by using the foreach command
​
    Ex5:
    Write a program that ask for an input until the user types in the Word STRIVE(case insensitive)
*/
namespace ExcersiceNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14;

            static void DoubleToInteger(double PI)
            {
                int PIinInteger = Convert.ToInt16(PI);
                Console.WriteLine(PIinInteger);
            }

            static void DoubleToDecimal(double PI)
            {
                decimal PIinDecimal = Convert.ToDecimal(PI);
                Console.WriteLine(PIinDecimal);
            }

            object x = false;
            x = 34;
            x = "camel";

            string[] Names = new string[5];
            Names[0] = "Helen";
            Names[1] = "Ola";
            Names[2] = "Urii";
            Names[3] = "Stas";
            Names[4] = "Sasha";

            foreach(string name in Names)
            {
                Console.WriteLine(name);
            }

            static void PlayWithUserAGame()
            {
                string UsersString;
                do
                {
                    UsersString = Console.ReadLine();
                    if (UsersString.Equals("STRIVE")) Console.WriteLine("You win!");
                    else Console.WriteLine("Try again");
                } while (!UsersString.Equals("STRIVE"));
            }

            string y = (x.ToString().ToUpper());
            Console.WriteLine(y);

            DoubleToInteger(PI);
            DoubleToDecimal(PI);
            PlayWithUserAGame();
        }
    }
}
