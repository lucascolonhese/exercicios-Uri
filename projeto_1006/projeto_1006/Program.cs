﻿using System;
using System.Globalization;

namespace projeto_1006
{
    class program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            media = ((a * 2) + (b * 3) + (c * 5)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("f1", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

