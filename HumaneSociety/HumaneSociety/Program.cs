﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Program
    {
        static void Main(string[] args)
        {
            Agency mainMenu = new Agency();
            mainMenu.Start();
            Console.ReadLine();
        }
    }
}
