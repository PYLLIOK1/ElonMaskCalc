using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class PowOperation : IOperation
    {
        public string Name => "pow";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands[0];
            for (int i = 1; i < Operands.Length; i++)
            {
                double pow = Operands[i];
                Result = Math.Pow(Convert.ToDouble(Result), pow);
            }
            return Result;
        }
    }
}
