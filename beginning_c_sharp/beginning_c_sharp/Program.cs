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
            Console.WriteLine("What´s your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + "!");
            Console.WriteLine("How old are youß");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You were born in " + Convert.ToString(2022 - age));


            Console.ReadLine();
        }
    }
}
