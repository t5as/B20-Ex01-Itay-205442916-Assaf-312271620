﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B20_Ex01_03
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter hour glass height: ");
            string strHeight = Console.ReadLine();
            int hourGlassHeight = int.Parse(strHeight);

            if (hourGlassHeight % 2 == 0)
            {
                hourGlassHeight -= 1;
            }

            B20_Ex01_02.Program.HourGlass(hourGlassHeight, hourGlassHeight, -2);
        }
    }
}
