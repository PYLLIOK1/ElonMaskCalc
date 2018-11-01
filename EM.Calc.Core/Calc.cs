using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

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
            List<string> files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "bin\\", "*.dll").ToList<string>();
            for (int i = 0; i < files.Count; i++)
            {
                files[i] = Path.GetFileName(files[i].Replace(".dll", ""));
                Assembly asm = Assembly.Load(files[i]);
                var ClassTypes = from t in asm.GetTypes()
                                 where t.IsClass && !t.IsAbstract &&
                                   (t.GetInterface("IOperation") != null)
                                 select t;
                foreach (Type item in ClassTypes)
                {
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
