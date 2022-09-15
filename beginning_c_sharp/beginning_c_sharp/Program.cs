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
            //Console.WriteLine("What´s your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("Hello " + userName + "!");

            //Console.WriteLine("How old are you?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age <= 0) 
            //    Console.WriteLine("You cant be 0 years old.");


            //Console.WriteLine("You were born in " + Convert.ToString(2022 - age));

            //Console.WriteLine("How old will you be in X years?");
            //int nextYear = Convert.ToInt32(Console.ReadLine());
            //int sumYear = age + nextYear;

            //console.writeline("in " + nextyear + " years you will be " + sumyear + ". ");

            //Console.WriteLine("How tall are you (in meters)?");
            //decimal height = Convert.ToDecimal(Console.ReadLine());

            //decimal multiplicator = 1;
            //Console.WriteLine("You are " + height * multiplicator + " meters tall.");

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 18 )
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


            Console.ReadLine();
        }
    }
}
