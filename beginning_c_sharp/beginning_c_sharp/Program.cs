using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("What´s your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + "!");

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 0)
                Console.WriteLine("You cant be 0 years old.");


            Console.WriteLine("You were born in " + Convert.ToString(2022 - age));

            Console.WriteLine("How old will you be in X years?");
            int nextYear = Convert.ToInt32(Console.ReadLine());
            int sumYear = age + nextYear;

            console.writeline("in " + nextyear + " years you will be " + sumyear + ". ");

            Console.WriteLine("How tall are you (in meters)?");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            decimal multiplicator = 1;
            Console.WriteLine("You are " + height * multiplicator + " meters tall.");


            //ask user age and act accordingly 
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                if (age == 17)
                {
                    Console.WriteLine("You can pass on if you are in company with an adult.");
                }
                else
                {
                    Console.WriteLine("YOU SHALL NOT PASS!");
                }
            }

            else
            {
                if (age >= 28)
                {
                    Console.WriteLine("Have fun!");
                }
                else
                {
                    Console.WriteLine("Please show me your ID!");
                }
            }

            //replacing letters from a variable

            Console.WriteLine("Type something!");
            string entry = Console.ReadLine();

            string replaced_entry = entry.Replace("U", "G").Replace("u", "g");

            Console.WriteLine("You typed " + entry);
            Console.WriteLine("I trolled you to say: " + replaced_entry);
            

            //trimming spaces and a's

            Console.WriteLine("wort:");
            string entry1 = Console.ReadLine();

            string trimmed_entry1 = entry1.Trim(' ', 'a');

            Console.WriteLine("Old String " + entry1 + ":");
            Console.WriteLine("New String " + trimmed_entry1 + ":");
            

            //skipping first 3 letters

            Console.WriteLine("wort:");
            string entry2 = Console.ReadLine();

            string trimmed_entry2 = entry2.Substring(3);


            Console.WriteLine("Old String " + entry2 + ":");
            Console.WriteLine("New String " + trimmed_entry2 + ":");

            
            //for-schleife

            for(int i = 1; i <= 1000; i ++)
            {
                Console.WriteLine("Number:" + i);
            }
            */
            //while-schleife

            int i = 0;
            while(i<=10)
            {
                Console.WriteLine(i);
                i++;
            }

            //Prevents the programm from closing until an imput
            Console.ReadLine();

        }
    }
}
