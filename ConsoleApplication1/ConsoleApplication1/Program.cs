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
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            string lowerName = name.ToLower();
            System.Console.WriteLine("What's your birthday? (MM/DD)");
            string birthday = System.Console.ReadLine();
            DateTime userDate = Convert.ToDateTime(birthday);
            DateTime dateNow = DateTime.Now.Date;
            System.Console.WriteLine("Hi, " + name);
            foreach (char letter in lowerName)
            {

                if (letter == 'h' || letter == 'H' || letter == 'a' || letter == 'A' ||
                    letter == 'l' || letter == 'L' || letter == 'f' || letter == 'F' ||
                    letter == 'n' || letter == 'N' || letter == 'o' || letter == 'O' ||
                    letter == 'r' || letter == 'R' || letter == 's' || letter == 'S' ||
                    letter == 'e' || letter == 'E' || letter == 'm' || letter == 'M' ||
                    letter == 'i' || letter == 'I' || letter == 'x' || letter == 'X')
                {
                    System.Console.WriteLine("Give me an.. " + letter);
                    System.Console.ReadLine();
                }
                else
                {
                    System.Console.WriteLine("Give me a.. " + letter);
                    System.Console.ReadLine();
                }
            }
            string newName = name.ToUpper();
            System.Console.WriteLine(newName + " is.. GRAND!");
            if (userDate == dateNow)
            {
                System.Console.WriteLine("Happy Birthday!");
            }
            else
            if (userDate < dateNow)
            {
                userDate = userDate.AddYears(1);
                System.Console.WriteLine("Your birthday is " + Math.Abs((userDate - dateNow).TotalDays) + " days away!");
            }
            else if (Math.Abs((userDate - dateNow).TotalDays) == 1)
            {
                System.Console.WriteLine("Your birthday is " + Math.Abs((userDate - dateNow).TotalDays) + " day away!");
            }
            else
            {
                System.Console.WriteLine("Your birthday is " + Math.Abs((userDate - dateNow).TotalDays) + " days away!");
            }
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
