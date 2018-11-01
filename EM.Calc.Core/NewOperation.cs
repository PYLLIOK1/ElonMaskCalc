using System;


namespace EM.Calc.Core
{
    public class NewOperation : IExtOperation
    {
        public string Name => "new";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public Guid Uid => new Guid("{DD306D70-43E3-4A67-879A-7A064593B1B8}");

        public string Description => "Возращает позитив";

        public int? ArgCount => 0;

        public double? Execute()
        {
            Result = double.PositiveInfinity;
            return Result;
        }
    }
}
