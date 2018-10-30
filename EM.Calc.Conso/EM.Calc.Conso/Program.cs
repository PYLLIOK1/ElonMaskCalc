using EM.Calc.Core;
using System;
using System.Linq;

namespace EM.Calc.Conso
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values;
            string operation, operands;
            var calc = new Core.Calc();

            // найти файл с операцией
            // загручить этот файл

            // найти операцию
            var type = typeof(SumOperation);
            var memebers = type.GetMembers();

            // добавить операцию в калькулятор











            string[] Operarions = calc.Operations
                .Select(o => o.Name)
                .ToArray();
            if(args.Length == 0)
            {
                Console.WriteLine("Список операций:");
                foreach (var item in Operarions)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Введите операцию: ");
                operation = Console.ReadLine();
                Console.WriteLine("Введите операнды: ");
                operands = Console.ReadLine();
                values = ConvertToDouble(operands.Split(new[] { " ", ";" }, StringSplitOptions.RemoveEmptyEntries));
            }
            else
            {
                operation = args[0].ToLower();
                values = ConvertToDouble(args, 1);
            }
            var result = calc.Execute(operation, values);
            Console.WriteLine(result);
            
            Console.Read();
        }
        private static double[] ConvertToDouble(string[] args, int start = 0 )
        {
            return args
                .Skip(start)
                .Select(Convert.ToDouble)
                .ToArray();
        }
    }
}
