﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class main
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.homeMenu();
            Console.ReadKey();
        }
    }
}
