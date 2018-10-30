using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    /// <summary>
    /// Операция
    /// </summary>
    public interface IOperation
    {
        string Name { get; }
        /// <summary>
        /// Операнды
        /// </summary>
        double[] Operands { get; set; }
        /// <summary>
        /// Выполнить операцию
        /// </summary>
        /// <returns>Результат</returns>
        double? Execute();
        /// <summary>
        /// Результат
        /// </summary>
        double? Result { get; }
    }
}
