using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, what's your name?");
            string name = System.Console.ReadLine();          
           
            System.Console.WriteLine("What's your birthday? (MM/DD)");
            System.Console.ReadKey();

            //Still working on cheers part 2
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            int Days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (birthDate.Year * 365 + birthDate.DayOfYear);
            int Years = Days / 365;
            string message = (Days >= 365) ? "Your age: " + Years + " years" : "Your age: " + Days + " days";

            Console.WriteLine(message);

            foreach (char letter in name)
            {

               
                    if (letter == 'h' || letter == 'H' || letter == 'a' || letter == 'A' ||
                    letter == 'l' || letter == 'L' || letter == 'f' || letter == 'F' ||
                    letter == 'n' || letter == 'N' || letter == 'o' || letter == 'O' ||
                    letter == 'r' || letter == 'R' || letter == 's' || letter == 'S' ||
                    letter == 'e' || letter == 'E' || letter == 'm' || letter == 'M' ||
                    letter == 'i' || letter == 'I' || letter == 'x' || letter == 'X')
                    {
                        System.Console.WriteLine("Give me an " + letter);
                    }else
                    {
                        System.Console.WriteLine("Give me a " + letter);
                    }
                  
               
                
               
                System.Console.ReadKey();

            }
 

            System.Console.WriteLine(name.ToUpper() + " is.. GRAND!");

            System.Console.ReadLine();
            //Get the user's name and print it.
            //Cheer the user on.
            //For example, if name is "Bob", output should be:

            //Give me a..b
            //Give me an ... o
            //Give me a ... b
            //BOB is.. GRAND!


        }
    }
}
