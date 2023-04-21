﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 37; double fahrenheit = 98.6;
            Console.WriteLine("Value of {0} celcius to fahrenheit is {1}",
                celcius, Converter.ToFahrenheit(celcius));
            Console.WriteLine("Value of {0} fahrenheit to celcius is {1}",
                fahrenheit, Converter.ToCelcius(fahrenheit));
            Console.ReadLine();
        }
    }
}