using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class Calc
    {
        public double Sum(double[] args)
        {
            return args.Sum();
        }
        public double Sub(double[] args)
        {
            double result = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                result = result - args[i];
            }
            return result;
        }
        public double Pow(double[] args)
        {
            double result = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                double pow = args[i];
                result = Math.Pow(result, pow);
            }
            return result;
        }
        public double Multi(double[] args)
        {
            double result = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                result = result * args[i];
            }
            return result;
        }
    }
}
