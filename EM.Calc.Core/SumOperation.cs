using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class SumOperation : IExtOperation
    {
        public string Name => "sum";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public Guid Uid => new Guid("{0218E2DF-9BCD-4A43-8AEC-F741A8D88217}");

        public string Description => "Сложение";

        public int? ArgCount => 2;

        public double? Execute()
        {
            Result = Operands.Sum();
            return Result;
        }
    }
}
