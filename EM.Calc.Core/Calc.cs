using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class Calc
    {
        public int Sum(int[] args)
        {
            return args.Sum();
        }
        public int Sub(int[] args)
        {
            int result = args[0];
            for(int i = 1; i < args.Length; i++)
            {
                result = result - args[i];
            }
            return result;
        }
        public double Pow(int[] args)
        {
            double result = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                double pow = args[i];
                result = Math.Pow(result, pow);
            }
            return result;
        }
        public int Multi(int[] args)
        {
            int result = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                result = result * args[i];
            }
            return result;
        }
    }
}
