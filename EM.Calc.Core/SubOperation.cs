using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class SubOperation : IExtOperation
    {
        public string Name => "sub";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public Guid Uid => new Guid("{167B7753-6339-43FB-9795-42148E86B043}");

        public string Description => "Разность";

        public int? ArgCount => 2;

        public double? Execute()
        {
            Result = Operands[0];
            for (int i = 1; i < Operands.Length; i++)
            {
                Result = Result - Operands[i];
            }
            return Result;
        }
    }
}
