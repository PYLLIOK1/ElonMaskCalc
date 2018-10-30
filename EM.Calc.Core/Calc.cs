using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EM.Calc.Core
{
    public class Calc
    {
        /// <summary>
        /// Операции
        /// </summary>

        public IList<IOperation> Operations { get; set; }

        public Calc()
        {
            Operations = new List<IOperation>();

            // получить текущую сборку
            var asm = Assembly.GetExecutingAssembly();

            // загрузить все типы из сборки
            var types = asm.GetTypes();

            // перебираем все классы в сборке
            foreach (var item in types)
            {
                // если класс реализаует заданный интерфейс
                if (item.GetInterface("IOperation") != null)
                {
                    //добавляем в операции экземпляр данного класса
                    var instance = Activator.CreateInstance(item);

                    var operation = instance as IOperation;
                    if (operation != null)
                    {
                        Operations.Add(operation);
                    }
                }
            }
        }
        public double? Execute(string operName, double[] values)
        {
            foreach (var item in Operations)
            {
                if (item.Name == operName)
                {
                    item.Operands = values;

                    item.Execute();

                    return item.Result;
                }
            }
            return null;
        }
        #region
        [Obsolete("Не используйте это, используйте Execute()")]
        public double? Sum(double[] args ,string operName)
        {
            return Execute(operName, args);
        }
        [Obsolete("Не используйте это, используйте Execute()")]
        public double? Sub(double[] args, string operName)
        {
            return Execute(operName, args);
        }
        [Obsolete("Не используйте это, используйте Execute()")]
        public double? Pow(double[] args, string operName)
        {
            return Execute(operName, args);
        }
        [Obsolete("Не используйте это, используйте Execute()")]
        public double? Multi(double[] args, string operName)
        {
            return Execute(operName, args);
        }
        [Obsolete("Не используйте это, используйте Execute()")]
        public double? New(double[] args, string operName)
        {
            return Execute(operName, args);
        }
        #endregion
    }
}
