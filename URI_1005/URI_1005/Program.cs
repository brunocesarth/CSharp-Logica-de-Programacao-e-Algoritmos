﻿using System;
using System.Globalization;

namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            MEDIA = ((A*3.5) + (B*7.5)) / (3.5 + 7.5);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
