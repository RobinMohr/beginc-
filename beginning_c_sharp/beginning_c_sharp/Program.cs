﻿using System;
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
            Console.WriteLine("wie heißt du?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + "!");
            Console.ReadLine();
        }
    }
}
