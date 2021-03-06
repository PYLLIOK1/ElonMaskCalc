﻿using System;

namespace EM.Calc.Conso
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mass = Array(args);
            var calc = new Core.Calc();
            switch (args[0])
            {
                case "sum":
                    Console.WriteLine(calc.Sum(mass));
                    break;
                case "sub":
                    Console.WriteLine(calc.Sub(mass));
                    break;
                case "pow":
                    Console.WriteLine(calc.Pow(mass));
                    break;
                case "multi":
                    Console.WriteLine(calc.Multi(mass));
                    break;
                default:
                    Console.WriteLine("Что-то пошло не так");
                    break;
            }
            Console.Read();
        }
        private static double[] Array(string[] args)
        {
            double[] mass = new double[args.Length - 1];
            int j = 0;
            for (int i = 1; i < args.Length; i++, j++)
            {
                mass[j] = Convert.ToDouble(args[i]);
            }
            return mass;
        }
    }
}
